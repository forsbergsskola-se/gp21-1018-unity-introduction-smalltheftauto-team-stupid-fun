using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFunctionsNR : PlayerMovement
{
    
    public PlayerMovementNR movement;
    
    void Start()
    {
        movement = GetComponent<PlayerMovementNR>();
        movement.enabled = false;
    }
    void Update()
    {

    }

    public void SetMovement(bool input)
    {
        movement.enabled = input;
    }
    
}
