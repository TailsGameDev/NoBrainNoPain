using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Executor : Inimigo
{
    protected float xScale;

    private void Awake()
    {
        xScale = transform.localScale.x;
        Invoke("OlhaProPlayer", 0.5f);
    }

    void OlhaProPlayer()
    {
        float n = 1;
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            eLadoDireito = GameObject.FindGameObjectWithTag("Player").transform.position.x > transform.position.x;
            if (eLadoDireito)
            { 
                n = -1;
            }
                transform.localScale = new Vector3(xScale * n, transform.localScale.y, transform.localScale.z);
        }
        print("olhou");
        Invoke("OlhaProPlayer", 0.5f);
    }
  
    
}
