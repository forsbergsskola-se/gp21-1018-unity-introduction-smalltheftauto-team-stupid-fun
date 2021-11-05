using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float damage;
    public float range;
    public float fireRate = 15f;
    public float nextTimeToFire = 0f;
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
        isShooting = Input.GetButton("Fire1");
        
        if (isShooting && !isReloading && bulletsLeft > 0 && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
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
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode.Impulse);
        
        RaycastHit hit;
        if (Physics.Raycast(firePoint.transform.position, firePoint.transform.up, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
        
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
