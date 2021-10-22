using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor.Tilemaps;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class DriverEK : MonoBehaviour {
    void Start() {

    }

    void Update() {
        if (Input.GetButtonDown("Interact-Vehicle")) {
            List<VehicleEK> vehicles = new List<VehicleEK>();
            FindObjectOfType<VehicleEK>();

            if (vehicles.Count == 0) {
                return;
            }

            float distance = Vector3.Distance(this.transform.position, vehicles[0].transform.position);
            VehicleEK vehicle = vehicles[0];

            for (int i = 0; i < vehicles.Count; i++) {
                if (Vector3.Distance(this.transform.position, vehicles[i].transform.position) < 7) {
                    vehicle = vehicles[i];
                    distance = Vector3.Distance(this.transform.position, vehicle.transform.position);
                }
            }

            if (distance < 7) {
                vehicle.EnterCar();
            }
        }
    }
}
