using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BulletPS : MonoBehaviour
{

    public GameObject hitEffect;

    private void Update()
    {
        Destroy(gameObject,5f);
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject,5f);
    }
}
