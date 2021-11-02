using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementPS : MonoBehaviour
{
    // private Rigidbody body;
    // public float speed;
    // public float rotationSpeed;
    // private float vertical;
    // private float horizontal;
    
    // Start is called before the first frame update
    void Start()
    {

        // body = GetComponent<Rigidbody>();
    }

    // private void FixedUpdate()
    // {
    //     vertical = Input.GetAxis("Vertical");
    //     horizontal = Input.GetAxis("Horizontal");
    //     body.velocity = (transform.forward * vertical) * speed * Time.fixedDeltaTime;
    //     transform.Rotate((transform.up * horizontal) * rotationSpeed * Time.fixedDeltaTime);
    // }



    //Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 5f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
        transform.Rotate(0f,0f,-180 * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
