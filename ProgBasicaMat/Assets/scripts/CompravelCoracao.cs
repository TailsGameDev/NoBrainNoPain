using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompravelCoracao : Compravel
{
    public int qtdLimite;

    private void Start () {
        if (Comprou.coracoes >= qtdLimite) {
            gameObject.SetActive(false);
        }
    }

    protected override void Efeito () {
        Comprou.coracoes = Comprou.coracoes + 1;
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        tomadanoPlayer tomadano = player.GetComponent<tomadanoPlayer>();
        tomadano.SomaAVida(10000); //cura tudo
        tomadano.ConfiguraVida();
        tomadano.SomaAVida(10000); //cura tudo
    }
}
