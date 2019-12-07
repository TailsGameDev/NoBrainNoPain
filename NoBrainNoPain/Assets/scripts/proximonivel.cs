using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class proximonivel : MonoBehaviour
{
    public string proximaCena;
    [SerializeField] GameObject loading;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag =="Player"){
            if (proximaCena == "Menu"){
                Comprou.pes = 0;
                Comprou.estamagos = 0;
                Comprou.coracoes = 0;
                Comprou.joelho = 0;
                ColetaCerebros.qtdAoNascer = 0;
            } else {
                ColetaCerebros player = GameObject.FindGameObjectWithTag("Player").GetComponent<ColetaCerebros>();
                player.SalvaQtdCerebros();
            }
            Instantiate(loading);
            SceneManager.LoadSceneAsync(proximaCena);
        }
    }
}
