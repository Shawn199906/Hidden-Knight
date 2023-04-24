using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffect : MonoBehaviour
{
    SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            GetComponent<SpriteRenderer>().color = new Color(1f, 0.3f, 0.3f);
        }
    }
    void Update()
    {
        sr.color = Color.Lerp(sr.color, Color.white, Time.deltaTime / 0.5f);
    }
}
