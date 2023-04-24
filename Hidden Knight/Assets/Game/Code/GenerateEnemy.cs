using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
//using System;

public class GenerateEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public int CountEnemy;
    //public Tilemap tilemap;
    public float WaitTime;
    public float NextTime;
    //private List<Vector3> randomGroundTileWorldPos;
    
    void Start()
    {
        //InitializeMap();
        StartCoroutine(spawnWaves());
    }

    /*void InitializeMap()
    {
        tilemap = GetComponent<Tilemap>();
        Vector3Int tmOrg = tilemap.origin;
        Vector3Int tmSz = tilemap.size;
        for (int x=tmOrg.x;x<tmSz.x;x++)
        {
            for (int y = tmOrg.y; y < tmSz.y; y++)
            {
                Vector3 cell = tilemap.GetCellCenterWorld(new Vector3Int(x+0.5f, y+0.5f, 0));
                randomGroundTileWorldPos.Add(cell);
            }
        }
    }*/

    IEnumerator spawnWaves()
    {
        yield return new WaitForSeconds(WaitTime);
        //System.Random rd = new System.Random();
        while (true)
        {
            for (int i = 0; i < CountEnemy; i++)
            {
                //int x = rd.Next(0, randomGroundTileWorldPos.Count);
                Vector3 EPosition = new Vector3(Random.Range(1.5f,39.5f), Random.Range(1.5f, 39.5f),1f);
                Quaternion ERotation = Quaternion.Euler(0, 0, 0);
                Instantiate(Enemy,EPosition,ERotation);
                yield return new WaitForSeconds(NextTime);
            }
        }
    }
}
