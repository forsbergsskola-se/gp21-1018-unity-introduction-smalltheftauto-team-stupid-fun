using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleEK : MonoBehaviour {

    private DriverEK driver;
    public GameObject car;
    public GameObject mainCamera;

    void Update() {
        if (Input.GetButtonDown("Interact-Vehicle")) {
            if (driver != null) {
                ExitCar();
            }
        }
    }

    // TODO: Nice! :)
    public void EnterCar(DriverEK driver) {
        this.driver = driver;
        car.GetComponent<DriverEK>();
        driver.gameObject.SetActive(false);
        GetComponent<CarControllerEK>().enabled = true;
        mainCamera.gameObject.SetActive(false);
    }

    void ExitCar() {
        driver.gameObject.transform.position = car.transform.position + new Vector3(3, 0, 0);
        driver.gameObject.SetActive(true);
        driver = null;
        GetComponent<CarControllerEK>().enabled = false;
        mainCamera.gameObject.SetActive(true);
    }
}
