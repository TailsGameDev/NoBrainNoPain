using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoMili : dadano
{
    AtaqueEspecial atkEspecial;

    private void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (tag == "mordida")
        {
            atkEspecial = player.GetComponentInChildren<AtaqueEspecial>();
        }
    }

    protected override void OnTriggerEnter2D(Collider2D col)
    {
        base.OnTriggerEnter2D(col); // a logica de dano estah na superclasse
        Invoke("Destroise", 0.2f);

        if (tag == "mordida"){
            if (col.tag == "Inimigo")
            {
                if (atkEspecial.GetPorcentagem() < 99)
                {
                    atkEspecial.SetPorcentagem(atkEspecial.GetPorcentagem() + 20);
                }
            }
        }
           
    }

    void Destroise()
    {
        Destroy(gameObject);
    }
}
