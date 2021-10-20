using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleEK : MonoBehaviour {

    public GameObject player;
    public CarMovementEK carMovementEK = new CarMovementEK();
    public GameObject car;

    void Update() {
        if (PlayerIsInCar()) {
            if (Vector3.Distance(player.transform.position, transform.position) < 5) {
                EnterCar();
            }
        } else {
            ExitCar();
        }
    }

    bool PlayerIsInCar() {
        return !player.activeInHierarchy;
    }

    void ExitCar() {
        if (Input.GetButtonDown("Interact-Vehicle")) {
            player.transform.position = transform.position;
            player.SetActive(true);
            GetComponent<CarMovementEK>().enabled = false;
            //carMovementEK.enabled = false;
        }
    }

    void EnterCar() {
        if (Input.GetButtonDown("Interact-Vehicle")) {
            player.SetActive(false);
            GetComponent<CarMovementEK>().enabled = true;
            //carMovementEK.enabled = true;
        }
    }
}


// private void EnterCar() {
//     this.player.SetActive(false);
//     GetComponent<CarMovementEK>().enabled = true;
//
//     // //get only one Component of that Type:
//     // CarMovementEK movement = GetComponent<CarMovementEK>();
//     // GetComponent<CarMovementEK>().enabled = true;
//     // //get ALL Components of that Type:
//     // CarMovementEK[] movements = GetComponent<CarMovementEK>();
//     // for (int i = 0; i < movements.Length; i++) {
//     //     CarMovementEK mov = movements[i];
//     //     mov.enabled = true;
//     // }
//}

// void Update() {
//     if (Input.GetKeyDown(KeyCode.F)) {
//         if (PlayerIsInCar()) {
//             if (Vector3.Distance(this.player.transform.position, this.transform.position) < 1)
//             { EnterCar(); }
//         } else {
//             ExitCar();
//         }
//     }
// }
