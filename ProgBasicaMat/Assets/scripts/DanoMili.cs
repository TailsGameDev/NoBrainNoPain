using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoMili : dadano
{
    float addvomito = 20f;
    Ataque atk;

    private void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        atk = player.GetComponent<Ataque>();
    }

    protected override void OnTriggerEnter2D(Collider2D col)
    {
        base.OnTriggerEnter2D(col);
        Invoke("Destroise", 0.0f);

        if (col.tag=="Inimigo")
        {
            if (atk.getVomitoAtual() < 99)
            {
                atk.setVomitoAtual(atk.getVomitoAtual() + 20);
            }
        }
           
    }

    void Destroise()
    {
        Destroy(gameObject);
    }
}
