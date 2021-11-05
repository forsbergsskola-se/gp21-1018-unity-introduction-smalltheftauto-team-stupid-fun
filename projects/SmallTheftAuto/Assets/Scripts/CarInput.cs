using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInput : MonoBehaviour {
    //components
    CarMovement carMovement;

    private void Awake() {
        carMovement = GetComponent<CarMovement>();
    }

    private void Update() {
        Vector3 inputVector = Vector3.zero;

        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
        inputVector.z = Input.GetAxis("Jump"); //break

        carMovement.SetInputVector(inputVector);
    }
}
