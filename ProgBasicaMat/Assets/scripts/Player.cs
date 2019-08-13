using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D  RB2D;
    bool podepular;


    void Start()
    {
        RB2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move();
    }

    public void move()
    {
        bool a = Input.GetKey("a");
        bool d = Input.GetKey("d");

        if (a)
        {
            RB2D.velocity = new Vector2(-5, 0);
        }

        if (d)
        {
            RB2D.velocity = new Vector2(+5, 0);
        }
        
    }
}