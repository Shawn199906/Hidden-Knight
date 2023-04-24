using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject BulletPrefab;
    public float bulletSpeed = 10f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject Bullet=Instantiate(BulletPrefab,Firepoint.position,Firepoint.rotation);
        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(Firepoint.right * bulletSpeed, ForceMode2D.Impulse);
    }
}
