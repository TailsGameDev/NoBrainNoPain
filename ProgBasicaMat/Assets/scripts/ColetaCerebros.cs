using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetaCerebros : MonoBehaviour
{
    static int qtdAoNascer;
    int qtdAtual;

    private void Start () {
        qtdAtual = qtdAoNascer;
    }

    private void OnTriggerEnter2D (Collider2D col) {
        if(col.tag == "cerebro") {
            qtdAtual += 1;
            Destroy(col.gameObject);
        }
    }

    public void SalvaQtdCerebros () {
        qtdAoNascer = qtdAtual;
    }

    public int GetQtdCerebros () {
        return qtdAtual;
    }
}
