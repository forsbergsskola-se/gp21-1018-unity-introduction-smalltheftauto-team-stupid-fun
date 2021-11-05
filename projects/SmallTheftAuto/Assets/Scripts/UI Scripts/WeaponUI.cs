using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponUI : MonoBehaviour
{
    public WeaponSwitching weaponState;
    public Sprite fist;
    public Sprite pistol;
    public Sprite machinegun;

    void Update()
    {
        ChangeWeaponSprite();
    }

    public void ChangeWeaponSprite()
    {
        if (weaponState.selectedWeapon == 0)
        {
            this.gameObject.GetComponent<Image>().sprite = fist;
        }
        
        if (weaponState.selectedWeapon == 1)
        {
            this.gameObject.GetComponent<Image>().sprite = pistol;
        }
        if (weaponState.selectedWeapon == 2)
            
        {
            this.gameObject.GetComponent<Image>().sprite = machinegun;
        }
    }
    
}
