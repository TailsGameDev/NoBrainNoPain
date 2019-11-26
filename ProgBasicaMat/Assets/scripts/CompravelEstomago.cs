using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompravelEstomago : Compravel
{
    public int qtdLimite;

    private void Start()
    {
        if (Comprou.estamagos >= qtdLimite)
        {
            gameObject.SetActive(false);
        }
    }

    protected override void Efeito()
    {
        Comprou.estamagos = Comprou.estamagos + 1;
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Ataque ataque = player.GetComponent<Ataque>();
    }


}
