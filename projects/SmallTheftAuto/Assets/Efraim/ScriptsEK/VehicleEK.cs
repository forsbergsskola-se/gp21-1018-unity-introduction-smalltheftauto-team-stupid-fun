using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleEK : MonoBehaviour {

    private DriverEK driver;
    public GameObject car;

    void Update() {
        if (Input.GetButtonDown("Interact-Vehicle")) {
            if (driver != null) {
                ExitCar();
            }
        }
    }

    public void EnterCar(DriverEK driver) {
        this.driver = driver;
        car.GetComponent<DriverEK>();
        driver.gameObject.SetActive(false);
        GetComponent<CarMovementEK>().enabled = true;
    }

    void ExitCar() {
        driver.gameObject.transform.position = car.transform.position + new Vector3(3, 0, 0);
        driver.gameObject.SetActive(true);
        driver = null;
        GetComponent<CarMovementEK>().enabled = false;
    }
}
