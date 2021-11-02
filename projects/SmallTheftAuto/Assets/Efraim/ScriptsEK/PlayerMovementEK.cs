using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementEK : MonoBehaviour {
    void Update() {

        if (Input.GetKey(KeyCode.LeftShift)) {
            transform.Translate(0, 0, 20f * Time.deltaTime * Input.GetAxis("Vertical"));
            transform.Rotate(0, 180f * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
        } else {
            transform.Translate(0, 0, 8f * Time.deltaTime * Input.GetAxis("Vertical"));
            transform.Rotate(0, 180f * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
        }
    }
}
