using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionNR : MonoBehaviour
{
    private BoxCollider box;
    private bool nearCar = false;
    public GameObject Car;
    public GameObject Player;
    private PlayerMovementNR movement;
    private CarFunctionsNR carFunc;
    private MeshRenderer renderer;
    
    void Start()
    {
        box = GetComponent<BoxCollider>();
        renderer = Player.GetComponent<MeshRenderer>();
        movement = Player.GetComponent<PlayerMovementNR>();
        carFunc = Car.GetComponent<CarFunctionsNR>();
    }
    
    void Update()
    {
        
    }
    
    private void OnTriggerStay(Collider other)
    {
        nearCar = other.tag == "Car";
        if (nearCar && Input.GetKeyDown("f"))
        {
            Debug.Log("Entered Car");
            renderer.enabled = false;
            carFunc.enabled = true;
            movement.enabled = false;
            // disabling PlayerMovement
            // enabling CarFunctions
        }
        if (Input.GetKeyDown("g"))
        {
            Debug.Log("Exit Car");
            carFunc.enabled = false;
            movement.enabled = true;
            Player.transform.position = Car.transform.position;
            renderer.enabled = true;
        }
    }
}
