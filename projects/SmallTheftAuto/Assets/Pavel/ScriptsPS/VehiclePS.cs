using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiclePS : MonoBehaviour
{
    public GameObject player;
    public CarMovementPS carMovementPS;
    public GameObject car;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerIsInCar())
        {
            LeaveCar();
        }
        else
        {
            if (Vector3.Distance(player.transform.position, car.transform.position) < 7)
            {
                EnterCar();
            }
            
        }
    }

    bool PlayerIsInCar()
    {
        if (player.activeInHierarchy)
        {
            return false;
        }

        return true;
    }

    void LeaveCar()
    {
        if (Input.GetKey(KeyCode.F))
        {
            player.transform.position = transform.position;
            player.SetActive(true);
            carMovementPS.enabled = false;
        }
    }

    void EnterCar()
    {
        if (Input.GetKey(KeyCode.F))
        {
            player.SetActive(false);
            carMovementPS.enabled = true;
        }
    }
}
