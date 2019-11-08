using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetaCerebros : MonoBehaviour {
    public static ColetaCerebros coletor;
    static int qtdAoNascer;
    int qtdAtual;
    [SerializeField] Text contadorHUD;

    private void Start () {
        coletor = this;
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

    public bool Pagar (int preco) {
        bool deu = false;
        if (qtdAtual >= preco) {
            qtdAtual = qtdAtual - preco;
            SalvaQtdCerebros();
            deu = true;
        }
        contadorHUD.text = "x" + qtdAtual;
        return deu;
    }
    //depois tem que fazer a questao de poder gastar cérebros. Recomendo fazer com função e deixar
    //a variável qtdAtual privada
}
