using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class DriverEK : MonoBehaviour
{
    public GameObject carek;
    void Start() {

    }

    void Update() {
        if (Input.GetButtonDown("Interact-Vehicle")) {

            List<VehicleEK> vehicle = new List<VehicleEK>();
            FindObjectOfType<VehicleEK>();

            if (Vector3.Distance(this.transform.position, carek.transform.position) < 7) {

            }
        }
    }
}
