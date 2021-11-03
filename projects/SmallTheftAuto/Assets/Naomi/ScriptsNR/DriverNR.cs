using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DriverNR : MonoBehaviour
{
    public GameObject refcanvas;
    public TMPro.TextMeshProUGUI textPref;
    public Vector3 offset;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact-Vehicle"))
        {
            VechileNR[] vechiles =  FindObjectsOfType<VechileNR>();

            if (vechiles.Length == 0)
            {
                return;
            }

            float distance = Vector3.Distance(this.transform.position, vechiles[0].transform.position);
            VechileNR vechile = vechiles[0];

            for (int i = 1; i < vechiles.Length; i++)
            {
                if (Vector3.Distance(this.transform.position, vechiles[i].transform.position) < distance)
                {
                    vechile = vechiles[i];
                    distance = Vector3.Distance(this.transform.position, vechile.transform.position);
                }
            }

            if (distance < 5)
            {
                vechile.EnterCar(GetComponent<DriverNR>());
                
                // text spawn
                TMPro.TextMeshProUGUI niceCar = Instantiate(textPref, transform.position + offset, Quaternion.identity);
                niceCar.transform.SetParent(refcanvas.transform, false);
            }

        }

    }
}
