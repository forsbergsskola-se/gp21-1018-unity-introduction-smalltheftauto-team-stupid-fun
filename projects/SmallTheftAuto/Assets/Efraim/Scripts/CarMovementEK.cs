using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementEK : MonoBehaviour {
    void Update() {
        transform.Translate(0f, 20f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
        transform.Rotate(0f, 0f, -250 * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
