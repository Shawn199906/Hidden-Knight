using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitWall : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.tag == "Enemy")
        {
            float x = MazeEmenyMovement.movePlay.x;
            float y = MazeEmenyMovement.movePlay.y;
            MazeEmenyMovement.movePlay = new Vector2(-x,-y);
        }
    }
}
