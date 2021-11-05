using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoost : MonoBehaviour
{
    private HealthSystem playerHealth;

    private void Awake()
    {
        playerHealth = FindObjectOfType<HealthSystem>();
    }

    private void OnTriggerEnter(Collider coll)
    {

        if (playerHealth.currentHealth < playerHealth.maxHealth)
        {
            Destroy(gameObject);
            playerHealth.Healing(30);
        }
    }
}
