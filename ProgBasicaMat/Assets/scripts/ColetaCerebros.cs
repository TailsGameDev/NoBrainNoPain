using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetaCerebros : MonoBehaviour {
    static int qtdAoNascer;
    int qtdAtual;
    [SerializeField] Text contadorHUD;

    private void Start () {
        if (contadorHUD == null) {
            GameObject contadorGameObject = GameObject.FindGameObjectWithTag("cerebroHUD");
            if (contadorGameObject != null) {
                contadorHUD = contadorGameObject.GetComponent<Text>();
            }
        }
        qtdAtual = qtdAoNascer;
        if (contadorHUD != null) {
            contadorHUD.text = "x" + qtdAtual;
        }
    }

    private void OnTriggerEnter2D (Collider2D col) {
        if (col.tag == "cerebro") {
            qtdAtual += 1;
            contadorHUD.text = "x" + qtdAtual;
            Destroy(col.gameObject);
        }
    }

    //chamar isso quando passar em checkpoint
    public void SalvaQtdCerebros () {
        qtdAoNascer = qtdAtual;
    }

    //depois tem que fazer a questao de poder gastar cérebros. Recomendo fazer com função e deixar
    //a variável qtdAtual privada
}
