using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoMili : dadano
{
    protected override void OnTriggerEnter2D(Collider2D col)
    {
        base.OnTriggerEnter2D(col);
        Invoke("Destroise", 0.1f);
    }

    void Destroise()
    {
        Destroy(gameObject);
    }
}
