using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementEK : MonoBehaviour {
    void Update() {
        transform.Translate(0f, 4f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
        transform.Rotate(0f, 0f, -180f * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
