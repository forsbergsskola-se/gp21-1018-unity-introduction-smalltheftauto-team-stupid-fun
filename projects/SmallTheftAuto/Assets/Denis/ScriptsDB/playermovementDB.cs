using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovementDB : MonoBehaviour
{
    void Start()
    {
       
    }

// Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 5f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
        transform.Rotate(0f,0f,-180 * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
