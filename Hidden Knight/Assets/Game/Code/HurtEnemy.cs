using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public int damage = 1;
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        //Instantiate(ImpactEffect,transform.position,transform.rotation);
        Destroy(gameObject);
    }
}
