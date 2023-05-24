using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval;
    public Vector3 bulletOffset;
    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            UpdateFiring();
        }
    }

    private void UpdateFiring()
    {
        if (Time.time - lastBulletTime > shootingInterval)
        {
            ShootBullet();
            lastBulletTime = Time.time;
        }
    }

    private void ShootBullet()
    {
        var bullet = Instantiate(
            bulletPrefabs,
            transform.position + bulletOffset,
            transform.rotation
        );
    }
}
