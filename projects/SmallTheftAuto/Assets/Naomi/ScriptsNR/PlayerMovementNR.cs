using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementNR : MonoBehaviour
{
    float speed = 20f;
    float rotationspeed = -200f;

    
    void Start()
    {

    }
    
    void FixedUpdate()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal")  * rotationspeed;
        
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, translation,0);
        transform.Rotate(0, 0, rotation);
    }
}
