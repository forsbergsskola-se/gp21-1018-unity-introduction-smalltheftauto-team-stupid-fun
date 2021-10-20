using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class VehicleEK : MonoBehaviour {
    public GameObject player;
    public CarMovementEK CarMovementEk;

    void Update() {
        if (Input.GetKeyDown(KeyCode.F)) {
            if (PlayerIsInCar()) {
                if (Vector3.Distance(
                    this.player.transform.position,
                    this.transform.position) < 1) {
                    EnterCar();
                }
            } else {
                ExitCar();
            }
        }
    }

    bool PlayerIsInCar() {
        return !this.player.activeInHierarchy;
    }

    private void ExitCar() {
        this.player.transform.position = this.transform.position;
        this.player.SetActive(true);
        this.CarMovementEk.enabled = false;
    }

    private void EnterCar() {
        this.player.SetActive(false);
        this.CarMovementEk.enabled = true;
    }
}
