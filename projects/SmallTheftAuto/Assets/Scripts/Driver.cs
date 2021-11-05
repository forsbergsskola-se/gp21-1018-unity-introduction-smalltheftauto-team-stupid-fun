using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour {
    void Update() {

        if (Input.GetButtonDown("Interact-Vehicle")) {
            Vehicle[] vehicles = FindObjectsOfType<Vehicle>();

            if (vehicles.Length == 0) {
                return;
            }

            float distance = Vector3.Distance(this.transform.position, vehicles[0].transform.position);
            Vehicle vehicle = vehicles[0];

            for (int i = 0; i < vehicles.Length; i++) {
                if (Vector3.Distance(this.transform.position, vehicles[i].transform.position) < distance) {
                    vehicle = vehicles[i];
                    distance = Vector3.Distance(this.transform.position, vehicle.transform.position);
                }
            }

            if (distance < 7) {
                vehicle.EnterCar(GetComponent<Driver>());
            }
        }
    }
}
