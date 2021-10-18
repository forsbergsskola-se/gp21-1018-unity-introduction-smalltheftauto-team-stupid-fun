using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Only, if the W-Key is currenly pressed...
        if (Input.GetKey(KeyCode.W))
        {
            //translate the player on the y-axis (which points up)
            transform.Translate(0f, 0.01f, 0f);
        }
        
        //First exercise:
        //make him walk backward, when S is pressed
        
        //Second exercise:
        //make him turn left, if A is pressed
        //transform.Rotate(0, 0, 0);
        
        //make him turn right, if D is pressed
        
        //Third exercise:
        //What problem exists again with Update, Movement, Frame-Rate (FPS)
        
        //Fourth exercise:
        //Input.GetAxis() instead of Input.GetKey()
        
    }
}
