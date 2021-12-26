using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class CarControllerEK : MonoBehaviour {

    [Header("Car Settings")]
    public float driftFactor = 0.95f;
    public float accelerationFactor = 30;
    public float breakForce = 100f;
    public float turnFactor = 3.5f;
    public float maxSpeed = 20;

    private float accelerationInput = 0;
    private float steeringInput = 0;

    private float currentBreakForce;
    private bool isBreaking;

    private float rotationAngle = 0;
    private float velocityVsUp = 0;

    private Rigidbody2D carRigidbody2D;

    private void Awake() {
        carRigidbody2D = GetComponent<Rigidbody2D>();
    }

    //framerate independent for physics calculation
    private void FixedUpdate() {
        ApplyEngineForce();
        ApplySteering();
        ApplyBreaking();
        KillOrthogonalVelocity();
    }

    // TODO: This is a good script. I hope that its functionality is also understood ;)
    private void ApplyEngineForce() {

        //create engine force
        Vector2 engineForceVector = transform.forward * accelerationInput * accelerationFactor;

        //apply force and push car forward
        carRigidbody2D.AddForce(engineForceVector, ForceMode2D.Force);

        //calc car speed
        velocityVsUp = Vector2.Dot(transform.forward, carRigidbody2D.velocity);

        //limit car velocity to maxSpeed in forward dir
        if (velocityVsUp > maxSpeed && accelerationInput > 0)
            return;

        //limit car reverse velocity to 50% maxSpeed
        if (velocityVsUp < -maxSpeed * 0.5 && accelerationInput < 0)
            return;

        //limit car velocity in all directions
        if (carRigidbody2D.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
            return;

        currentBreakForce = isBreaking ? breakForce : 0f;

        if (isBreaking) {
            ApplyBreaking();
        }

        //apply drag if no acceleration input, so car stops
        if (accelerationInput == 0)
            carRigidbody2D.drag = Mathf.Lerp(carRigidbody2D.drag, 3.0f, Time.fixedDeltaTime * 3);
        else carRigidbody2D.drag = 0;
    }

    private void ApplyBreaking() {
        carRigidbody2D.drag = currentBreakForce * breakForce;
    }

    private void ApplySteering() {
        //limit turn ability when moving slowly
        float minTurnSpeedFactor = carRigidbody2D.velocity.magnitude / 8;
        minTurnSpeedFactor = Mathf.Clamp01(minTurnSpeedFactor);

        //update rotation angle based on input
        rotationAngle -= steeringInput * turnFactor * minTurnSpeedFactor;

        //apply steering by rotating car object
        carRigidbody2D.MoveRotation(rotationAngle);
    }

    void KillOrthogonalVelocity() {
        //counteract orthogonal force to minimise unwanted drift
        Vector2 forwardVelocity = transform.forward * Vector2.Dot(carRigidbody2D.velocity, transform.forward);
        Vector2 rightVelocity = transform.right * Vector2.Dot(carRigidbody2D.velocity, transform.right);

        carRigidbody2D.velocity = forwardVelocity + rightVelocity * driftFactor;
    }

    public void SetInputVector(Vector2 inputVector) {
        steeringInput = inputVector.x;
        accelerationInput = inputVector.y;
        isBreaking = Input.GetKey(KeyCode.Space);
    }
}

    // [Header("Car Settings")]
    //  public float driftFactor = 0.95f;
    //  public float accelerationFactor = 30;
    //  public float turnFactor = 0.4f;
    //  public float maxSpeed = 20;
    //  public float defaultDrag = 0.2f;
    //  public float defaultAngularDrag = 0.2f;
    //
    //  private float accelerationInput = 0;
    //  private float steeringInput = 0;
    //  private float breakInput = 0;
    //
    //  private float currentBreakForce;
    //  private bool isBreaking;
    //
    //  private float velocityVsUp = 0;
    //
    //  [SerializeField] private float breakForce;
    //
    //  Vector3 eulerAngleVelocity;
    //  Quaternion deltaRotation;
    //
    //  Rigidbody carRigidbody;
    //  BoxCollider carBoxCollider;
    //
    //  private void Awake() {
    //      carRigidbody = GetComponent<Rigidbody>();
    //      carRigidbody.drag = defaultDrag;
    //      carRigidbody.angularDrag = defaultAngularDrag;
    //  }
    //
    //  //framerate independent for physics calculation
    //  private void FixedUpdate() {
    //      ApplyEngineForce();
    //      ApplySteering();
    //      ApplyBreaking();
    //      KillOrthogonalVelocity();
    //  }
    //
    //  private void ApplyEngineForce() {
    //
    //      //create engine force
    //      Vector3 engineForceVector = transform.forward * accelerationInput * accelerationFactor;
    //
    //      //apply force and push car forward
    //      carRigidbody.AddForce(engineForceVector, ForceMode.Force);
    //
    //      //calc car speed
    //      velocityVsUp = Vector3.Dot(transform.forward, carRigidbody.velocity);
    //
    //      //limit car velocity to maxSpeed in forward dir
    //      if (velocityVsUp > maxSpeed && accelerationInput > 0)
    //          return;
    //
    //      //limit car reverse velocity to 50% maxSpeed
    //      if (velocityVsUp < -maxSpeed * 0.5 && accelerationInput < 0)
    //          return;
    //
    //      //limit car velocity in all directions
    //      if (carRigidbody.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
    //          return;
    //
    //      //apply drag if no acceleration input, so car stops
    //      if (accelerationInput == 0)
    //          carRigidbody.drag = Mathf.Lerp(carRigidbody.drag, defaultDrag, Time.fixedDeltaTime * 3);
    //      else carRigidbody.drag = defaultDrag;
    //
    //      currentBreakForce = isBreaking ? breakForce : defaultDrag;
    //
    //      if (isBreaking) {
    //          ApplyBreaking();
    //      }
    //  }
    //
    //  private void ApplyBreaking() {
    //      carRigidbody.drag = currentBreakForce * breakForce;
    //  }
    //
    //  private void ApplySteering() {
    //
    //          //limit turn ability when moving slowly
    //          float minTurnSpeedFactor = carRigidbody.velocity.magnitude / 8;
    //          minTurnSpeedFactor = Mathf.Clamp01(minTurnSpeedFactor);
    //
    //          //update rotation angle based on input
    //          eulerAngleVelocity.y -= -steeringInput * turnFactor * minTurnSpeedFactor;
    //
    //          Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * turnFactor);
    //
    //          //apply steering by rotating car object
    //          carRigidbody.MoveRotation(carRigidbody.rotation * deltaRotation);
    //
    //          //apply angular drag if no steering input, to stop rotation
    //          if (Input.GetKey(KeyCode.E)) {
    //              //carRigidbody.angularVelocity
    //              transform.rotation = Quaternion.identity;
    //          }
    //
    //          // if (steeringInput == 0)
    //          //     carRigidbody.angularDrag = Mathf.Lerp(defaultAngularDrag, carRigidbody.angularDrag, Time.fixedDeltaTime * 0.1f);
    //          // else this.defaultAngularDrag = carRigidbody.angularDrag;
    //  }
    //
    //  void KillOrthogonalVelocity() {
    //      //counteract orthogonal force to minimise unwanted drift
    //      Vector3 forwardVelocity = transform.forward * Vector3.Dot(carRigidbody.velocity, transform.forward);
    //      Vector3 rightVelocity = transform.right * Vector3.Dot(carRigidbody.velocity, transform.right);
    //
    //      carRigidbody.velocity = forwardVelocity + rightVelocity * driftFactor;
    //  }
    //
    //  public void SetInputVector(Vector3 inputVector) {
    //      steeringInput = inputVector.x;
    //      accelerationInput = inputVector.y;
    //      breakInput = inputVector.z;
    //      isBreaking = Input.GetKey(KeyCode.Space);
    //  }
