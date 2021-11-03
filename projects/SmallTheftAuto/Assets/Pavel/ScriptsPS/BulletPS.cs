using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPS : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    
    void Start()
    {
        rb.velocity = (transform.right * speed);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyPS enemy = hitInfo.GetComponent<EnemyPS>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
