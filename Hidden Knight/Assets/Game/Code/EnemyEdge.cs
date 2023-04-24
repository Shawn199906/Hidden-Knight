using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEdge : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisonEnter2D(Collision2D enemy)
    {
        if (enemy.gameObject.tag == "Map")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
