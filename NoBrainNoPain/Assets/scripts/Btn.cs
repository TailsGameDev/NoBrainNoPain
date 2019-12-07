using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn : MonoBehaviour
{
    public void RecarregaCena () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
