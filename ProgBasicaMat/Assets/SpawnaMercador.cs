using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnaMercador : MonoBehaviour
{

    private void Update () {
        GameObject mercador = GameObject.FindGameObjectWithTag("mercador");
        if (mercador != null) {
            mercador.transform.position = transform.position;
            Destroy(gameObject);
        }
    }
}
