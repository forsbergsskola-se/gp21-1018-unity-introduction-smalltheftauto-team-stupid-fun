using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementEK : MonoBehaviour {
    void Update() {
        transform.Translate(0, 0, 20f * Time.deltaTime * Input.GetAxis("Vertical"));

        if (Input.GetAxis("Vertical") == 1) {
            transform.Rotate(0, 160 * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
        }  if (Input.GetAxis("Vertical") == -1) {
            transform.Rotate(0, -120 * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
        }
    }
}
