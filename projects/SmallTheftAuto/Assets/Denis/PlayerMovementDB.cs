using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementDB : MonoBehaviour
{
    private float speed = 10f;
    private float rotationspeed = -100f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Use Input.GetAxis() instead of Input.GetKey()
        float translation = Input.GetAxis("Vertical") * speed;
        float roation = Input.GetAxis("Horizontal") * rotation;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        
        // translate the player on the y-axis (which points up)
        transform.Translate(0, translation, 0);
        transform.Translate(0, 0, rotation);

        // First Exercise:
        // make him walk backwards, when S is pressed

        // Second Exercise:
        // make him turn left, if A is pressed
        // transform.Rotate(xAngle, yAngle, zAngle);
        // make him turn right, if D is pressed

        // Third Exercise:
        // What problem exists again with Update, Movement, Frame-Rate (FPS)?
    }
}
