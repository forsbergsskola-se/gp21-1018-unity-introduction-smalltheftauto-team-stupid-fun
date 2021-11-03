using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyPS : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
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
