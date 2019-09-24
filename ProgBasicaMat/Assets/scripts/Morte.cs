using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Morte : MonoBehaviour
{
    public static float tempoParaMorrer = 2f;

    public static Morte morte;

    void Awake()
    {
        if (!morte)
        {
            morte = this;
        }
    }

    public static void Morre()
    {
        print("morre chamado");
        // Morte.morte.Invoke("Morre2", Morte.tempoParaMorrer);
        morte.StartCoroutine("Die");
    }

    IEnumerator Die()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        print("to na corrotina");
        yield return new WaitForSeconds(1);
        
    }

    /*
    


    

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            Morre();
        }
    }

    public static void Morre()
    {
       Morte.morte.Invoke("Morre2", Morte.tempoParaMorrer);
    }

    private static void Morre2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    */
}

