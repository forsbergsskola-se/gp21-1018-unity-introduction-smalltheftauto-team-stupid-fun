using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class VehiclePS : MonoBehaviour {
    
    private DriverPS driver;
    public GameObject car;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact-Vehicle"))
        {
            if (driver != null)
            {
                Leave();
            }
        }
    }

    void Leave()
    {
        driver.gameObject.transform.position = car.transform.position + new Vector3(5, 0, 0);
        driver.gameObject.SetActive(true);
        driver = null;
        GetComponent<CarMovementPS>().enabled = false;
    }

    public void EnterCar(DriverPS driver )
    {
        this.driver = driver;
        car.GetComponent<DriverPS>();
        driver.gameObject.SetActive(false);
        GetComponent<CarMovementPS>().enabled = true;
    }
}
