using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    public static Vector3 posicao;
    public static string cena;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if ( collider.tag == "Player")
        {
            cena = SceneManager.GetActiveScene().name;
            posicao = transform.position;
        }
       
    }
}

