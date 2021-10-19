using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCarPS : MonoBehaviour
{

    public PlayerMovementPS movement;
    // Start is called before the first frame update
    void Start()
    {
        movement.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
