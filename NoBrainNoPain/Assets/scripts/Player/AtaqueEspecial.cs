using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEspecial : MonoBehaviour
{
    [SerializeField] Ataque ataque;

    [SerializeField] float porcentagem;
    [SerializeField] BarraDeMedicaoDeRecurso barrinhaUI;

    void Start(){
        barrinhaUI.SetPorcentagem(0);
    }

    public void SetPorcentagem(float porcentagem)
    {
        if(DesbloqueouAtaqueEspecial())
        {
            this.porcentagem = porcentagem;
            barrinhaUI.SetPorcentagem(this.porcentagem);
        }
    }

    bool DesbloqueouAtaqueEspecial(){
        return Comprou.estamagos != 0;
    }

    public void TentarAtaqueEspecial(){
        if (porcentagem > 99) {
            
            ataque.Atacar();

            barrinhaUI.SetPorcentagem(0);
        }
    }

    public float GetPorcentagem()
    {
        return this.porcentagem;
    }
}