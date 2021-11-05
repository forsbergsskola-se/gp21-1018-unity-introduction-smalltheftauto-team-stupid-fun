using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoost : MonoBehaviour
{
    public HealthSystem playerHealth;
    
    
    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (playerHealth.currentHealth < playerHealth.maxHealth)
        {
            Destroy(gameObject);
            playerHealth.Healing(30);
        }
    }
}
