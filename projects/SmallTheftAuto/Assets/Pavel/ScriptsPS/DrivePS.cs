using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivePS : MonoBehaviour
{
    public GameObject player;
    public CarMovementPS carMovementPS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void EnterCar()
    {
        if (Input.GetButtonDown("Interact-Vehicle"))
        {
            player.SetActive(false);
            carMovementPS.enabled = true;
        }
    }
}
