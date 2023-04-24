using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MazeEmenyMovement : MonoBehaviour
{
    public float speed = 10f;
    public float moveTimer;
    public float moveTime = 5;
    public static Vector2 movePlay;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveauto();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveTimer>=0)
        {
            Vector3 thisScale = this.transform.localScale;
            Vector2 position = rb.position;
            position += movePlay * speed * Time.deltaTime;
            rb.MovePosition(position);
            moveTimer -= Time.deltaTime;
        }
        else
        {
            moveauto();
            moveTimer = moveTime;
        }
    }

    void moveauto()
    {
        System.Random rd = new System.Random();
        float x = rd.Next(-1, 2);
        float y = rd.Next(-1, 2);
        int ran = rd.Next(0,2);
        int rantwo = rd.Next(0,2);
        int ranthree = rd.Next(0, 2);
        int ranfour = rd.Next(0,2);
        if (x==0&&y==0)
        {
            if (ran==0)
            {
                if (rantwo==0)
                {
                    movePlay = new Vector2(1, 0);
                }
                else if (rantwo==1)
                {
                    movePlay = new Vector2(-1, 0);
                }
            }
            else if(ran==1){
                if (rantwo==0)
                {
                    movePlay = new Vector2(0, 1);
                }
                else if (rantwo==1)
                {
                    movePlay = new Vector2(0, -1);
                }
            }
        }
        else
        {
            if (ranthree==0)
            {
                if (x!=0)
                {
                    movePlay = new Vector2(x, 0);
                }
                else if (x==0)
                {
                    if (ranfour==0)
                    {
                        movePlay = new Vector2(1, 0);
                    }else if (ranfour == 1)
                    {
                        movePlay = new Vector2(-1, 0);
                    }
                }
            }else if (ranthree == 1)
            {
                if (y!=0)
                {
                    movePlay = new Vector2(0, y);
                }
                else if (y == 0)
                {
                    if (ranfour == 0)
                    {
                        movePlay = new Vector2(0, 1);
                    }
                    else if (ranfour == 1)
                    {
                        movePlay = new Vector2(0, -1);
                    }
                }
            }
        }
        /*Vector3 thisScale = this.transform.localScale;
        if (x!=0)
        {
            thisScale.x = Math.Abs(thisScale.x) * x;
            transform.localScale = thisScale;
        }*/
    }
}
