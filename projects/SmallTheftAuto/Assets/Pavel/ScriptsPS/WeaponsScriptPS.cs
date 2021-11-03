using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponsScriptPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public abstract class Weapon
{
    public int power;
    public string name;

    public Weapon(int power, string name)
    {
        this.power = power;
        this.name = name;
    }

    protected int Power
    {
        get
        {
            return power;
        }
    }
}

public class Hands : Weapon
{
    public Hands() : base(5, "Unarmed")
    {
        
    }
}

public class HandPistol : Weapon
{
    public HandPistol() : base(15, "Hand Pistol")
    {
        
    }
}

public class MachineGun : Weapon
{
    public MachineGun() : base(8, "Machine Gun")
    {
        
    }
}


