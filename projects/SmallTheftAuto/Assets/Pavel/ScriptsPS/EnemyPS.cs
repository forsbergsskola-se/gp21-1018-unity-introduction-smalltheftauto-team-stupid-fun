using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyPS : MonoBehaviour
{
    public float health = 100f;

    public GameObject deathEffect;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, quaternion.identity);
        Destroy(gameObject);
    }
}
