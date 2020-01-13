using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompravelJoelho : Compravel
{
    protected void Start()
    {
        if (Comprou.joelho >= qtdLimite)
        {
            gameObject.SetActive(false);
        }
    }
    protected override void Efeito(){
        Comprou.joelho += 1;
        PehPlayer pehPlayer = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<PehPlayer>();
        pehPlayer.RestauraPulo();
    }
}
