using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void FixedUpdate()
    {
        // 5 seconds could be a private serializefield field. Then we would avoid having magic numbers in the code and in addition we can have diffrent ranges for different guns.
        // For example habgun's bullet destroys after 2 seconds and AR's bullet lasts for 4 seconds.
        Destroy(gameObject,5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        Destroy(gameObject);
    }
}
