using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 1;
    public GameObject DeathEffect;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health<=0)
        {
            Die();
            ScoreSystem.PlayerScore += 10;
        }
    }

    void Die()
    {
        Instantiate(DeathEffect,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }
}
