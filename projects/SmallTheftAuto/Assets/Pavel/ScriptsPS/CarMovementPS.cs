using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementPS : MonoBehaviour
{
        
        
    
    

    // Update is called once per frame
    void Update()
    {
        

        transform.Translate(0f, 20f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
        transform.Rotate(0f,0f,-400 * Time.deltaTime * Input.GetAxis("Horizontal"));


    }
}


