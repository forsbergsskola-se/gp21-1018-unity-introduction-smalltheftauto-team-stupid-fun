using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerEK : MonoBehaviour {

    [Header("Car Settings")]
    public float driftFactor = 0.95f;
    public float accelerationFactor = 30;
    public float turnFactor = 3.5f;
    public float maxSpeed = 20;

    private float accelerationInput = 0;
    private float steeringInput = 0;

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
        KillOrthogonalVelocity();
    }

    private void ApplyEngineForce() {
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

        //apply drag if no acceleration input, so car stops
        if (accelerationInput == 0)
            carRigidbody2D.drag = Mathf.Lerp(carRigidbody2D.drag, 3.0f, Time.fixedDeltaTime * 3);
        else carRigidbody2D.drag = 0;

        //create engine force
        Vector2 engineForceVector = transform.forward * accelerationInput * accelerationFactor;

        //apply force and push car forward
        carRigidbody2D.AddForce(engineForceVector, ForceMode2D.Force);
    }

    private void ApplySteering() {
        //limit turn ability when moving slowly
        float minTurnSpeedFactor = carRigidbody2D.velocity.magnitude / 10;
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
    }
}
