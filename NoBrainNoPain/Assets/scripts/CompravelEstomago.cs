using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompravelEstomago : Compravel
{
        protected void Start()
    {
        if (Comprou.estamagos >= qtdLimite)
        {
            gameObject.SetActive(false);
        }
    }
    protected override void Efeito()
    {
        Ataque playerAtk = GameObject.FindGameObjectWithTag("Player").GetComponent<Ataque>();
        Comprou.estamagos = Comprou.estamagos + 1;
        playerAtk.setVomitoAtual(100);
    }
}
