using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverEK : MonoBehaviour {
    void Update() {

        if (Input.GetButtonDown("Interact-Vehicle")) {
            VehicleEK[] vehicles = FindObjectsOfType<VehicleEK>();

            if (vehicles.Length == 0) {
                return;
            }

            float distance = Vector3.Distance(this.transform.position, vehicles[0].transform.position);
            VehicleEK vehicle = vehicles[0];

            for (int i = 0; i < vehicles.Length; i++) {
                if (Vector3.Distance(this.transform.position, vehicles[i].transform.position) < distance) {
                    vehicle = vehicles[i];
                    distance = Vector3.Distance(this.transform.position, vehicle.transform.position);
                }
            }

            if (distance < 7) {
                vehicle.EnterCar(GetComponent<DriverEK>());
            }
        }
    }
}
