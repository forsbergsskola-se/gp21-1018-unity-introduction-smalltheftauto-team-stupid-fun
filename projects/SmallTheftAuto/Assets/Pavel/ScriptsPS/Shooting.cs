using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public int magazineSize, bulletsLeft;
    public float reloadTime;
    public bool isReloading, isShooting;
    
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;


    private void Awake()
    {
        bulletsLeft = magazineSize;
        
    }

    void Update()
    {
        isShooting = Input.GetButtonDown("Fire1");
        
        if (isShooting && !isReloading && bulletsLeft > 0)
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R) && bulletsLeft < magazineSize && !isReloading)
        {
            Reload();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        bulletsLeft--;
    }

    void Reload()
    {
        isReloading = true;
        Invoke("ReloadFinished", reloadTime);
    }

    void ReloadFinished()
    {
        bulletsLeft = magazineSize;
        isReloading = false;
    }
}
