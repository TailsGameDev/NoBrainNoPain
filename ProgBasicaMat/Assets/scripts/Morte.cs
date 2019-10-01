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
        } else {
            Destroy(gameObject);
        }
    }

    public static void PlayerMorre()
    {
        morte.Invoke("RecarregaCena", tempoParaMorrer);
    }

    void RecarregaCena () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

