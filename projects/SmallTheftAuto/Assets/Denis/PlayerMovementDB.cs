using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementDB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        // only, if the W-Key is currently pressed...
        if (Input.GetKey(KeyCode.W)) {
        // translate the player on the y-axis (which points up)
        transform.Translate(0f, 0.01f, 0f);
    }
        
    // First Exercise:
    // make him walk backwards, when S is pressed
        
    // Second Exercise:
    // make him turn left, if A is pressed
    // transform.Rotate(xAngle, yAngle, zAngle);
    // make him turn right, if D is pressed
        
    // Third Exercise:
    // What problem exists again with Update, Movement, Frame-Rate (FPS)?
        
    // Fourth Exercise:
    // Use Input.GetAxis() instead of Input.GetKey()

    }
}
