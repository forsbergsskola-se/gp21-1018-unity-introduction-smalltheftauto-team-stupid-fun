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
        driver.gameObject.transform.position = car.transform.position;
        driver.gameObject.SetActive(true);
        driver = null;
        GetComponent<CarMovementEK>().enabled = false;
    }
}

    // public void EnterCar() {
    //     if (Input.GetButtonDown("Interact-Vehicle")) {
    //         player.SetActive(false);
    //         GetComponent<CarMovementEK>().enabled = true;
    //         //carMovementEK.enabled = true;
    //     }
    // }
    //
    // public void ExitCar() {
    //     if (Input.GetButtonDown("Interact-Vehicle")) {
    //         player.transform.position = transform.position;
    //         player.SetActive(true);
    //         GetComponent<CarMovementEK>().enabled = false;
    //         //carMovementEK.enabled = false;
    //     }
    // }

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
