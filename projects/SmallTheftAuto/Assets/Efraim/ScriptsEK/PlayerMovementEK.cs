using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementEK : MonoBehaviour {
    void Update() {
        transform.Translate(0, 0, 4f * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(0, 180f * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
    }
}
