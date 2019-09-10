using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PosicionaPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        if (Checkpoint.cena != null && Checkpoint.cena != SceneManager.GetActiveScene().name)
        {
            SceneManager.LoadScene(Checkpoint.cena);
        }

        if (SceneManager.GetActiveScene().name == Checkpoint.cena)
        {
            transform.position = Checkpoint.posicao;
        }
    }

}
