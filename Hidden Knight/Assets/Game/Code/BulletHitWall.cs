using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHitWall : MonoBehaviour
{
    public GameObject Hiteffect;
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(Hiteffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);
    }
}
