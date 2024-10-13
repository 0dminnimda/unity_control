using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    Rigidbody BulletRigidbody;
    public Transform newBulletTransform;
    public float speed = 100f;
    public float destroyTime = 4f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject newBullet = Instantiate(
            bullet, newBulletTransform.position, newBulletTransform.rotation);
        BulletRigidbody = newBullet.GetComponent<Rigidbody>();
        BulletRigidbody.AddForce(newBulletTransform.transform.forward * speed, ForceMode.Impulse);
        Destroy(newBullet, destroyTime);
    }
}
