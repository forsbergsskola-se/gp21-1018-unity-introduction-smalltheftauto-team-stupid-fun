using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerEK : MonoBehaviour {

    [Header("Car Settings")]
    public float driftFactor = 0.95f;
    public float accelerationFactor = 50;
    public float breakForce = 100f;
    public float turnFactor = 3.5f;
    public float maxSpeed = 30;

    private float accelerationInput = 0;
    private float steeringInput = 0;
    private float breakInput = 0;
    private bool isBreaking;

    private float velocityVsUp = 0;

    Vector3 eulerAngleVelocity;
    Quaternion deltaRotation;

    Rigidbody carRigidbody;
    BoxCollider carBoxCollider;

    private void Awake() {
        carRigidbody = GetComponent<Rigidbody>();
    }

    //framerate independent for physics calculation
    private void FixedUpdate() {
        ApplyEngineForce();
        ApplySteering();
        ApplyBreaking();
        KillOrthogonalVelocity();
    }

    private void ApplyEngineForce() {

        //create engine force
        Vector3 engineForceVector = transform.forward * accelerationInput * accelerationFactor;

        //apply force and push car forward
        carRigidbody.AddForce(engineForceVector, ForceMode.Force);

        //calc car speed
        velocityVsUp = Vector3.Dot(transform.forward, carRigidbody.velocity);

        //limit car velocity to maxSpeed in forward dir
        if (velocityVsUp > maxSpeed && accelerationInput > 0)
            return;

        //limit car reverse velocity to 50% maxSpeed
        if (velocityVsUp < -maxSpeed * 0.5 && accelerationInput < 0)
            return;

        //limit car velocity in all directions
        if (carRigidbody.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
            return;

        //apply drag if no acceleration input, so car stops
        if (accelerationInput == 0)
            carRigidbody.drag = Mathf.Lerp(carRigidbody.drag, 3.0f, Time.fixedDeltaTime * 3);
        else carRigidbody.drag = 0;

        if (isBreaking) {
            ApplyBreaking();
        }
    }

    private void ApplyBreaking() {
        carBoxCollider
    }

    private void ApplySteering() {

        //limit turn ability when moving slowly
        float minTurnSpeedFactor = carRigidbody.velocity.magnitude / 10;
        minTurnSpeedFactor = Mathf.Clamp01(minTurnSpeedFactor);

        //update rotation angle based on input
        eulerAngleVelocity.y -= steeringInput * turnFactor * minTurnSpeedFactor;

        Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.fixedDeltaTime);

        //apply steering by rotating car object
        carRigidbody.MoveRotation(carRigidbody.rotation * deltaRotation);

        //carRigidbody.MoveRotation(rotationAngle);
    }

    void KillOrthogonalVelocity() {
        //counteract orthogonal force to minimise unwanted drift
        Vector3 forwardVelocity = transform.forward * Vector3.Dot(carRigidbody.velocity, transform.forward);
        Vector3 rightVelocity = transform.right * Vector3.Dot(carRigidbody.velocity, transform.right);

        carRigidbody.velocity = forwardVelocity + rightVelocity * driftFactor;
    }

    public void SetInputVector(Vector3 inputVector) {
        steeringInput = inputVector.x;
        accelerationInput = inputVector.y;
        breakInput = inputVector.z;
    }
}

    // [Header("Car Settings")]
    // public float driftFactor = 0.95f;
    // public float accelerationFactor = 30;
    // public float breakFactor = 100f;
    // public float turnFactor = 3.5f;
    // public float maxSpeed = 20;
    //
    // private float accelerationInput = 0;
    // private float steeringInput = 0;
    // private float breakInput = 0;
    //
    // private bool isBreaking;
    //
    // private float rotationAngle = 0;
    // private float velocityVsUp = 0;
    //
    // private Rigidbody2D carRigidbody2D;
    //
    // private void Awake() {
    //     carRigidbody2D = GetComponent<Rigidbody2D>();
    // }
    //
    // //framerate independent for physics calculation
    // private void FixedUpdate() {
    //     ApplyEngineForce();
    //     ApplySteering();
    //     ApplyBreakForce();
    //     KillOrthogonalVelocity();
    // }
    //
    // private void ApplyBreakForce() {
    //     //create break force
    //     Vector2 breakForceVector = transform.forward * breakInput * breakFactor;
    //
    //     //apply force and push car forward
    //     carRigidbody2D.AddForce(breakForceVector, ForceMode2D.Force);
    // }
    //
    // private void ApplyEngineForce() {
    //
    //     //create engine force
    //     Vector2 engineForceVector = transform.forward * accelerationInput * accelerationFactor;
    //
    //     //apply force and push car forward
    //     carRigidbody2D.AddForce(engineForceVector, ForceMode2D.Force);
    //
    //     //calc car speed
    //     velocityVsUp = Vector2.Dot(transform.forward, carRigidbody2D.velocity);
    //
    //     //limit car velocity to maxSpeed in forward dir
    //     if (velocityVsUp > maxSpeed && accelerationInput > 0)
    //         return;
    //
    //     //limit car reverse velocity to 50% maxSpeed
    //     if (velocityVsUp < -maxSpeed * 0.5 && accelerationInput < 0)
    //         return;
    //
    //     //limit car velocity in all directions
    //     if (carRigidbody2D.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
    //         return;
    //
    //     //apply drag if no acceleration input, so car stops
    //     if (accelerationInput == 0)
    //         carRigidbody2D.drag = Mathf.Lerp(carRigidbody2D.drag, 3.0f, Time.fixedDeltaTime * 3);
    //     else carRigidbody2D.drag = 0;
    // }
    //
    // private void ApplySteering() {
    //     //limit turn ability when moving slowly
    //     float minTurnSpeedFactor = carRigidbody2D.velocity.magnitude / 10;
    //     minTurnSpeedFactor = Mathf.Clamp01(minTurnSpeedFactor);
    //
    //     //update rotation angle based on input
    //     rotationAngle -= steeringInput * turnFactor * minTurnSpeedFactor;
    //
    //     //apply steering by rotating car object
    //     carRigidbody2D.MoveRotation(rotationAngle);
    // }
    //
    // void KillOrthogonalVelocity() {
    //     //counteract orthogonal force to minimise unwanted drift
    //     Vector2 forwardVelocity = transform.forward * Vector2.Dot(carRigidbody2D.velocity, transform.forward);
    //     Vector2 rightVelocity = transform.right * Vector2.Dot(carRigidbody2D.velocity, transform.right);
    //
    //     carRigidbody2D.velocity = forwardVelocity + rightVelocity * driftFactor;
    // }
    //
    // public void SetInputVector(Vector2 inputVector) {
    //     steeringInput = inputVector.x;
    //     accelerationInput = inputVector.y;
    // }
    //
    // public void SetBreakVector(Vector2 inputBreak) {
    //     breakInput = inputBreak.x;
    // }
