using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingspotPS : MonoBehaviour
{

    public bool hasCar;
    public GameObject carPrefabPS;
    
    
    void Start()
    {
        if (hasCar)
        {
            var car = Instantiate(carPrefabPS);
            car.transform.position = this.transform.position + new Vector3(0,0,0);
        }
    }
}
