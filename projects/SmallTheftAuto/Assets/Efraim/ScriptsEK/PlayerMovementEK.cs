using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementEK : MonoBehaviour {

    [SerializeField] float moveSpeed;
    [SerializeField] private float runSpeed;
    [SerializeField] private float rotationSpeed;

    private void Update() {
        Move();
    }

    private void Move() {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W)) {
            transform.Translate(0, 0, runSpeed * Time.deltaTime * Input.GetAxis("Vertical"));
            transform.Rotate(0,rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
        }
        else {
            transform.Translate(0, 0,moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"));
            transform.Rotate(0,rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
        }
    }

    // private void Movement() {
    //     float horizontalInput = Input.GetAxis("Horizontal");
    //     float verticalInput = Input.GetAxis("Vertical");
    //
    //     Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
    //     float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
    //     movementDirection.Normalize();
    //
    //     transform.Translate(movementDirection * moveSpeed * inputMagnitude * Time.deltaTime, Space.World);
    //
    //     if (movementDirection != Vector2.zero) {
    //         Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
    //         transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
    //     }
    // }
}
