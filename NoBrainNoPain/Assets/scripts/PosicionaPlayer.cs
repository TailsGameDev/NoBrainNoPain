using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PosicionaPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //se estou na cena do meu checkpoint, teleporto para a posicao do checkpoint
        if (SceneManager.GetActiveScene().name == Checkpoint.cena) {
            transform.position = Checkpoint.posicao;
        }

    }

}
