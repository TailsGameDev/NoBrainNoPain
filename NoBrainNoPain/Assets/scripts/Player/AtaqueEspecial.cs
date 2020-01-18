using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEspecial : MonoBehaviour
{
    [SerializeField] Ataque ataque;

    [SerializeField] float porcentagemDaBarrinha;
    float porcentagemInicialDaBarrinha = 0;
    [SerializeField] BarraDeMedicaoDeRecurso barrinhaUI;

    void Start(){
        barrinhaUI.SetPorcentagem(porcentagemInicialDaBarrinha);
    }

    public void SetPorcentagemDaBarrinha(float porcentagem)
    {
        if(DesbloqueouAtaqueEspecial())
        {
            this.porcentagemDaBarrinha = porcentagem;
            barrinhaUI.SetPorcentagem(this.porcentagemDaBarrinha);
        }
    }

    bool DesbloqueouAtaqueEspecial(){
        return Comprou.estamagos != 0;
    }

    public void TentarAtaqueEspecial(){
        if (porcentagemDaBarrinha > 99) {

            ataque.Atacar();

            barrinhaUI.SetPorcentagem(0);
        }
    }

    public float GetPorcentagemDaBarrinha()
    {
        return this.porcentagemDaBarrinha;
    }
}