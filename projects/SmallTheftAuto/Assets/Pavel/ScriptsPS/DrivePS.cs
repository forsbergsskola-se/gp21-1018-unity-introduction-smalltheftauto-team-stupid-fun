using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivePS : MonoBehaviour
{
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact-Vehicle"))
        {
            VehiclePS[] vehicle = FindObjectsOfType<VehiclePS>();
            


            for (int i = 0; i < vehicle.Length; i++)
            {
                if (Vector3.Distance(this.transform.position, vehicle[i].transform.position) < 7)
                {
                    
                }
            }
        }
    }
}
