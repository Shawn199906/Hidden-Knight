using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private HealthController healthController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            getDamage();
        }
    }
    void getDamage()
    {
        healthController.playerHealth= healthController.playerHealth-damage;
        healthController.updateHealth();
        //this.gameObject.SetActive(false);
    }
}
