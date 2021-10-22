using System.Collections;
using System.Collections.Generic;
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
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (player.activeInHierarchy)
            {
                player.SetActive(false);
                carMovement.enabled = true;
            }
            else
            {
                player.transform.position = this.transform.position;
                player.SetActive(true);
                carMovement.enabled = false;
            }
        }
        
    }

    
}
