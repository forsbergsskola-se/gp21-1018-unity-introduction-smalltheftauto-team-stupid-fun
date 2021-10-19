using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementNR : MonoBehaviour
{
    private float speed = 20f;
    private float rotationspeed = -400f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationspeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        
        transform.Translate(0f, translation, 0f);
        transform.Rotate(0, 0, rotation);
        


    }
}
