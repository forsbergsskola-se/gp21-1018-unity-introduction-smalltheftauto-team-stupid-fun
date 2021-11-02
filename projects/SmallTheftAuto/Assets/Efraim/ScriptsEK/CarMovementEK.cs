using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementEK : MonoBehaviour {
    void Update() {
        transform.Translate(0, 0, 20f * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(0, 200 * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
    }
}
