using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//eh abstract para que seja criada uma nova classe para cada item a ser comprado
public abstract class Compravel : MonoBehaviour
{
    [SerializeField] Text precoText;
    [SerializeField] protected int qtdLimite = 1;

    public void OnComprado (int preco) {
        // deu eh true se o player tinha cerebros suficientes
        bool deu = ColetaCerebros.coletor.Pagar(preco);

        if (deu) {
            Efeito();
            gameObject.SetActive(false);
        } else
        {
            StartCoroutine(PiscaTexto(precoText));
        }
    }

    protected abstract void Efeito();

    IEnumerator PiscaTexto(Text text){
        float tempoPiscando = 1f;
        float t = tempoPiscando;
        Color original = text.color;
        text.color = Color.red;
        while(t > 0.75*tempoPiscando){
            t-= Time.deltaTime;
            yield return null;
        }
        text.color = original;
        while(t > 0.5*tempoPiscando){
            t-= Time.deltaTime;
            yield return null;
        }
        text.color = Color.red;
        while(t > 0.25*tempoPiscando){
            t-= Time.deltaTime;
            yield return null;
        }
        text.color = original;
    }
    
}
