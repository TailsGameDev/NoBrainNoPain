using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoMili : dadano
{
    float addvomito = 20f; // soh eh usado se for uma mordida
    Ataque atk;

    private void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (tag == "mordida")
        {
            atk = player.GetComponent<Ataque>();
        }
    }

    protected override void OnTriggerEnter2D(Collider2D col)
    {
        base.OnTriggerEnter2D(col); // a logica de dano estah na superclasse
        Invoke("Destroise", 0.2f);

        if (tag == "mordida"){
            if (col.tag == "Inimigo")
            {
                if (atk.getVomitoAtual() < 99)
                {
                    atk.setVomitoAtual(atk.getVomitoAtual() + 20);
                }
            }
        }
           
    }

    void Destroise()
    {
        Destroy(gameObject);
    }
}
