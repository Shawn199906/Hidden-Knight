using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private float spawnTime = 15f;
    [SerializeField] private GameObject Enemy;
    [SerializeField] private bool isSpawn = true;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    private IEnumerator SpawnEnemy()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnTime);
        while (isSpawn)
        {
            yield return wait;
            Instantiate(Enemy,transform.position,Quaternion.identity);
        }
    }
}
