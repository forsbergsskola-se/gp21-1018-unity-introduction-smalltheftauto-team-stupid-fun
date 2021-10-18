using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementEK : MonoBehaviour
{
    //movement speed variables
    private float movementSpeed = 10f;
    private float rotationSpeed = -200f;
    private float jumpHeight = 10f;

    //framerate independent
    void FixedUpdate()
    {
        //using Input.GetAxis() method
        //public static float GetAxis(string axisName);
        float translation = Input.GetAxis("Vertical") * movementSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        float jump = Input.GetAxis("Jump") * jumpHeight;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        jump *= Time.deltaTime;

        transform.Translate(0, translation, 0);
        transform.Rotate(0, 0, rotation);
        transform.Translate(jump, 0, 0);

    }
}
        // // only, if the W-Key is currently pressed...
        // if (Input.GetKey(KeyCode.W)) {
        //     // translate the player on the y-axis (which points up)
        //     transform.Translate(0f, 0.01f, 0f);
        // }
        //
        // // First Exercise:
        // // make him walk backwards, when S is pressed
        //
        // // Second Exercise:
        // // make him turn left, if A is pressed
        // // transform.Rotate(xAngle, yAngle, zAngle);
        // // make him turn right, if D is pressed
        //
        // // Third Exercise:
        // // What problem exists again with Update, Movement, Frame-Rate (FPS)?
        //
        // // Fourth Exercise:
        // // Use Input.GetAxis() instead of Input.GetKey()
