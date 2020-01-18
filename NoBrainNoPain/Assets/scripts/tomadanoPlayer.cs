﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomadanoPlayer : tomadano
{
    private void Awake () {
        if (barraDeVida == null) {
            if (GameObject.FindGameObjectWithTag("barraVidaPlayer") != null) {
                barraDeVida = GameObject.FindGameObjectWithTag("barraVidaPlayer").GetComponent<BarraDeMedicaoDeRecurso>();
            }
        }
    }

    public void ConfiguraVida () {
        barraDeVida.maximoDeRecurso = vidaMaxima;
        int coracoesComprados = Comprou.coracoes;
        while (coracoesComprados > 0) {
            coracoesComprados = coracoesComprados - 1;
            vidaMaxima = vidaMaxima * 1.25f;
            barraDeVida.maximoDeRecurso = vidaMaxima;
            barraDeVida.AplicarMelhoria();
        }
    }

    private void Update () {
        barraDeVida.SetPorcentagem(vida);
    }

    protected override void Start()
    {
        ConfiguraVida();
        base.Start();
    }

    protected override void AoMorrer () {
        Morte.PlayerMorre();
        base.AoMorrer();
    }
}
