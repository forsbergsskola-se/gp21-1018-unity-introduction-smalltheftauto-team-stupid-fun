using System;
using UnityEngine;

public class CarMovementEK : MonoBehaviour {

    private float horizontalInput;
    private float verticalInput;
    private float currentSteerAngle;
    private float currentBreakForce;
    private bool isBreaking;

    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteerAngle;

    [SerializeField] private WheelCollider flwCollider;
    [SerializeField] private WheelCollider frwCollider;
    [SerializeField] private WheelCollider rlwCollider;
    [SerializeField] private WheelCollider rrwCollider;

    [SerializeField] private Transform flwTransform;
    [SerializeField] private Transform frwTransform;
    [SerializeField] private Transform rlwTransform;
    [SerializeField] private Transform rrwTransform;

    private void FixedUpdate() {

        HandleMotor();
        HandleSteering();
        UpdateWheels();

    }


    private void HandleMotor() {
        flwCollider.motorTorque = verticalInput * motorForce;
        frwCollider.motorTorque = verticalInput * motorForce;
        currentBreakForce = isBreaking ? breakForce : 0f;
        if (isBreaking) {
            ApplyBreaking();
        }
    }

    private void ApplyBreaking() {
        flwCollider.brakeTorque = currentBreakForce;
        frwCollider.brakeTorque = currentBreakForce;
        rlwCollider.brakeTorque = currentBreakForce;
        rrwCollider.brakeTorque = currentBreakForce;
    }

    private void HandleSteering() {
        currentSteerAngle = maxSteerAngle * horizontalInput;
        flwCollider.steerAngle = currentSteerAngle;
        frwCollider.steerAngle = currentSteerAngle;
    }

    private void UpdateWheels() {
        UpdateSingleWheel(flwCollider, flwTransform);
        UpdateSingleWheel(frwCollider, frwTransform);
        UpdateSingleWheel(rlwCollider, rlwTransform);
        UpdateSingleWheel(rrwCollider, rrwTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform) {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}


// void Update() {
//     transform.Translate(0, 0, 20f * Time.deltaTime * Input.GetAxis("Vertical"));
//
//     if (Input.GetAxis("Vertical") == 1) {
//         transform.Rotate(0, 160 * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
//     }  if (Input.GetAxis("Vertical") == -1) {
//         transform.Rotate(0, -120 * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
//     }
// }
