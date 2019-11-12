using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//eh abstract para que seja criada uma nova classe para cada item a ser comprado
public abstract class Compravel : MonoBehaviour
{
    public void OnComprado (int preco) {
        // deu eh true se o player tinha cerebros suficientes
        bool deu = ColetaCerebros.coletor.Pagar(preco);

        if (deu) {
            Efeito();
            gameObject.SetActive(false);
        }
    }

    protected abstract void Efeito();
    
}
