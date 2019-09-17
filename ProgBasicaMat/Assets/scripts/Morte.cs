using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Morte : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            Invoke("Morre", 1f);
        }
    }

    public void Morre()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

