using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInputHandlerEK : MonoBehaviour {
    //components
    CarControllerEK carController;

    private void Awake() {
        carController = GetComponent<CarControllerEK>();
    }

    private void Update() {
        Vector3 inputVector = Vector3.zero;

        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
        inputVector.z = Input.GetAxis("Jump");

        carController.SetInputVector(inputVector);
    }
}

// private void Update() {
//     Vector2 inputVector = Vector2.zero;
//     Vector2 inputBreak = Vector2.zero;
//
//     inputVector.x = Input.GetAxis("Horizontal");
//     inputVector.y = Input.GetAxis("Vertical");
//     inputBreak.x = -Input.GetAxis("Jump");
//
//     carController.SetInputVector(inputVector);
// }
