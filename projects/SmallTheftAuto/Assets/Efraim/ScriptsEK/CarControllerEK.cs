using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerEK : MonoBehaviour {

    [Header("Car Settings")]
    public float driftFactor = 0.95f;
    public float accelerationFactor = 30.0f;
    public float turnFactor = 3.5f;

    private float accelerationInput = 0;
    private float steeringInput = 0;

    private float rotationAngle = 0;

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
        //create an engine force
        Vector2 engineForceVector = transform.forward * accelerationInput * accelerationFactor;
        carRigidbody2D.AddForce(engineForceVector, ForceMode2D.Force);
    }

    private void ApplySteering() {
        rotationAngle -= steeringInput * turnFactor;
        carRigidbody2D.MoveRotation(rotationAngle);
    }

    void KillOrthogonalVelocity() {
        Vector2 forwardVelocity = transform.forward * Vector2.Dot(carRigidbody2D.velocity, transform.forward);
        Vector2 rightVelocity = transform.right * Vector2.Dot(carRigidbody2D.velocity, transform.right);

        carRigidbody2D.velocity = forwardVelocity + rightVelocity * driftFactor;
    }

    public void SetInputVector(Vector2 inputVector) {
        steeringInput = inputVector.x;
        accelerationInput = inputVector.y;
    }
}
