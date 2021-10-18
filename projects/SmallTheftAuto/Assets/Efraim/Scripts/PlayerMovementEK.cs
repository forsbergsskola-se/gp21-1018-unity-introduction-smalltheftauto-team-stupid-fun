using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementEK : MonoBehaviour
{
    private float speed = 20f;
    private float rotationspeed = 400f;
    void FixedUpdate()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationspeed;


    }
}

        // only, if the W-Key is currently pressed...
        // if (Input.GetKey(KeyCode.W)) {
        //     // translate the player on the y-axis (which points up)
        //     transform.Translate(0f, 0.03f, 0f);
        // } else if (Input.GetKey(KeyCode.S)) {
        //     transform.Translate(0f, -0.03f, 0f);
        // } else if  (Input.GetKey(KeyCode.D)) {
        //     transform.Rotate(0f, 0f, -0.5f);
        // } else if (Input.GetKey(KeyCode.A)) {
        //     transform.Rotate(0f, 0f, 0.5f);
        // }

        // Second Exercise:
        // make him turn left, if A is pressed
        // transform.Rotate(xAngle, yAngle, zAngle);
        // make him turn right, if D is pressed

        // Third Exercise:
        // What problem exists again with Update, Movement, Frame-Rate (FPS)?

        // Fourth Exercise:
        // Use Input.GetAxis() instead of Input.GetKey()
