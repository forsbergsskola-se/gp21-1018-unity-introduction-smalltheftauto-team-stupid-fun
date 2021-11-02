using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VechileNR : MonoBehaviour
{
    private DriverNR driver;
    public GameObject car;
    public Vector3 offset;


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
                LeaveCar();
            }
        } 
    }
    
    public void EnterCar(DriverNR driver)
    {
        this.driver = driver;
        car.GetComponent<DriverNR>();
        driver.gameObject.SetActive(false);
        GetComponent<CarMovementNR>().enabled = true;
    }

    public void LeaveCar()
    {
        driver.gameObject.transform.position = car.transform.position + offset;
        driver.gameObject.SetActive(true);
        driver = null;
        GetComponent<CarMovementNR>().enabled = false;
    }
    
}
