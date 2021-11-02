using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VechileNR : MonoBehaviour
{
    public GameObject player;
    public CarMovementNR carMovement;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerIsInCar()) 
        { 
            LeaveCar();
        } 
        else 
        {
            EnterCar();
        }
    }

    public bool PlayerIsInCar()
    {
        return !player.activeInHierarchy;
    }


    public void EnterCar()
    {
        float carDistance = Vector3.Distance(player.transform.position, this.transform.position);

        if (carDistance < 5)
        {
            if (Input.GetButtonDown("Interact-Vehicle"))
            {
                player.SetActive(false);
                carMovement.enabled = true;
            }
        }
    }

    public void LeaveCar()
    {
        if (Input.GetButtonDown("Interact-Vehicle"))
        {
            player.transform.position = transform.position;
            player.SetActive(true);
            carMovement.enabled = false;
        }
    }
    
}
