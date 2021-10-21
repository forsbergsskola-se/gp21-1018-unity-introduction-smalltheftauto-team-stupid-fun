using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DrivePS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact-Vehicle"))
        {
            VehiclePS[] vehicles = FindObjectsOfType<VehiclePS>();
            
            if (vehicles.Length == 0)
            {
                return;
            }
            
            float distance = Vector3.Distance(this.transform.position, vehicles[0].transform.position);
            VehiclePS vehicle = vehicles[0];
            
            for (int i = 1; i < vehicles.Length; i++)
            {
                if (Vector3.Distance(this.transform.position, vehicles[i].transform.position) < distance)
                {
                    vehicle = vehicles[i];
                    distance = Vector3.Distance(this.transform.position, vehicle.transform.position);
                }
            }
            
            if (distance < 7)
            {
                vehicle.EnterCar();
            }
        }
    }
}
