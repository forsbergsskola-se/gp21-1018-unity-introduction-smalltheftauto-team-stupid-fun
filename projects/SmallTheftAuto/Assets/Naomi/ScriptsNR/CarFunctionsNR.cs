using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFunctionsNR : MonoBehaviour
{
    
    public PlayerMovementNR movement;
    
    void Start()
    {
        movement.enabled = false;
    }

    
    void FixedUpdate()
    {
        Input.GetKey("E");
    }
}
