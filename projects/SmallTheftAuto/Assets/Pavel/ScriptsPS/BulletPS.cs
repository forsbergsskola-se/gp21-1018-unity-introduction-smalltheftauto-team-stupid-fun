using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BulletPS : MonoBehaviour
{

    

    private void Update()
    {
        Destroy(gameObject,5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        Destroy(gameObject);
    }
}
