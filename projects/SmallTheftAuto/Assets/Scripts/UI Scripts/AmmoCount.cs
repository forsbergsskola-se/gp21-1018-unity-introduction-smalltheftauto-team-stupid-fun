using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoCount : MonoBehaviour
{
    public TMPro.TextMeshProUGUI magSize;
    public TMPro.TextMeshProUGUI bullLeft;
    public Shooting pistol;
    public Shooting machineGun;
    
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
    }
}
