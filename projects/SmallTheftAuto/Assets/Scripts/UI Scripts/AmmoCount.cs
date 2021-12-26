using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoCount : MonoBehaviour
{
    public TMPro.TextMeshProUGUI magSize;
    public TMPro.TextMeshProUGUI bullLeft;
    public Shooting pistol;
    public Shooting machineGun;
    
    // TODO: Quite good, but it would've been better, if there was something like:
    // public Shooting[] weapons;
    // and maybe: public Shooting[] activeWeapon;
    void Update()
    {
        if (machineGun.isActiveAndEnabled)
        {
            magSize.text = machineGun.magazineSize.ToString();
            bullLeft.text = machineGun.bulletsLeft.ToString();
        }
 
        if (pistol.isActiveAndEnabled)
        {
            magSize.text = pistol.magazineSize.ToString();
            bullLeft.text = pistol.bulletsLeft.ToString();
        }
        else if (!machineGun.isActiveAndEnabled && !pistol.isActiveAndEnabled)
        {
            magSize.text = "0";
            bullLeft.text = "0";
        }
    }
}
