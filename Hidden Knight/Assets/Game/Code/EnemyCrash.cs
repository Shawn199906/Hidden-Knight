using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCrash : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.tag=="Enemy")
        {
            Destroy(gameObject);
        }
    }
}
