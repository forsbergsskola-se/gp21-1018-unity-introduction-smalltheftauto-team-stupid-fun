using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleEK : MonoBehaviour {

    private DriverEK driver;
    public GameObject car;

    private void Awake() {
        driver = GetComponent<DriverEK>();
    }

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
        driver.gameObject.transform.position = car.transform.position;
        driver.gameObject.SetActive(true);
        driver = null;
        GetComponent<CarMovementEK>().enabled = false;
    }
}
