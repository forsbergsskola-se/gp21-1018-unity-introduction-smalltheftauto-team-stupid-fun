using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour {

    private Driver driver;
    public GameObject car;

    void Update() {
        if (Input.GetButtonDown("Interact-Vehicle")) {
            if (driver != null) {
                ExitCar();
            }
        }
    }

    public void EnterCar(Driver driver) {
        this.driver = driver;
        car.GetComponent<Driver>();
        driver.gameObject.SetActive(false);
        GetComponent<CarMovement>().enabled = true;
    }

    void ExitCar() {
        driver.gameObject.transform.position = car.transform.position + new Vector3(3, 0, 0);
        driver.gameObject.SetActive(true);
        driver = null;
        GetComponent<CarMovement>().enabled = false;
    }
}
