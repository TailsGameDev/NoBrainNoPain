using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{   
    [SerializeField] GameObject randomBtn;
    [SerializeField] GameObject loading;
    public void GoToScene(string name)
    {
        Comprou.joelho = 0;
        Instantiate(loading);
        SceneManager.LoadSceneAsync(name);
    }

    public void Sair(){
        Application.Quit();
    }

    public void RandomButton(){
        int r = Random.Range(0,3);
        switch (r){
            case 0: GoToScene("CutSceneInicial"); break;
            case 1: GoToScene("Creditos"); break;
            case 2: Destroy(randomBtn); break;
        }
    }
}
