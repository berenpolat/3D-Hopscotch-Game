using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateWhiteBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;

    public float bulletSpeed = 20f;
    private float timeSinceLastBullet = 0;

    private void Update()
    {
        timeSinceLastBullet += Time.deltaTime;
        if (timeSinceLastBullet >= 2f)
        {
            // Instantiate a bullet at the specified spawn point
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

            // Add force to the bullet to move forward in the x-axis
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = transform.forward * bulletSpeed;

            timeSinceLastBullet = 0f;
        }
    }
}
