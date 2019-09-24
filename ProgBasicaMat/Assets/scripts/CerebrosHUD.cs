using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//esse script supoe que o player terah o script ColetaCerebros

public class CerebrosHUD : MonoBehaviour
{
    Text texto;
    string textoInicial;
    [SerializeField] ColetaCerebros coletor;

    void Start()
    {
        texto = GetComponent<Text>();
        textoInicial = texto.text;
    }

    //seria mais eficiente chamar soh qd a quantidade fosse atualizada, mas por agora pode ficar assim, por praticidade.
    private void Update () {
        AtualizaQtdCerebros(coletor.GetQtdCerebros());
    }

    void AtualizaQtdCerebros (int qtd) {
        texto.text = textoInicial + qtd;
    }

}
