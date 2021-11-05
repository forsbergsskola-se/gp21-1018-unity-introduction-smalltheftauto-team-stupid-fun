using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponUI : MonoBehaviour
{
    public Sprite fist;
    public Sprite pistol;
    public Sprite machinegun;
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.gameObject.GetComponent<Image>().sprite = fist;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            this.gameObject.GetComponent<Image>().sprite = pistol;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
            
        {
            this.gameObject.GetComponent<Image>().sprite = machinegun;
        }
    }
}
