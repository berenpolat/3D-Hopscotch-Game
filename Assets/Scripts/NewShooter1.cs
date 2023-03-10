using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewShooter1 : MonoBehaviour
{
    public float speed = 2f;
    public float right = -1.32f;
    public float left = -3.69f;
    private int direction = 1;

    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;

    public float bulletSpeed = 20f;

    private float timeSinceLastBullet = 0f;

    private void Update()
    {
        // Move the obstacle in the y-axis direction
        transform.Translate(Vector3.forward * direction * speed * Time.deltaTime);

        // Check if the obstacle has reached the top or bottom position
        if (transform.position.z >= left)
        {
            direction = 1;
        }
        else if (transform.position.z <= right)
        {
            direction = -1;
        }

        // Check if it's time to spawn a bullet
        timeSinceLastBullet += Time.deltaTime;
        if (timeSinceLastBullet >= 2f)
        {
            // Instantiate a bullet at the specified spawn point
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

            // Add force to the bullet to move forward in the z-axis
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = transform.forward * bulletSpeed;

            timeSinceLastBullet = 0f;
        }
    }
}
