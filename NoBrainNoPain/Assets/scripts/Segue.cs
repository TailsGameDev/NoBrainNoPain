using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segue : MonoBehaviour
{
    [SerializeField] Transform seguir;
    [SerializeField] bool segueX = true, segueY = true;

    private void Start () {
        if (seguir == null) {
            seguir = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void Update()
    {
        Vector3 novaPosicao = new Vector3(0,0,transform.position.z);
        if (segueX) novaPosicao += new Vector3(seguir.position.x , 0 , 0);
        if (segueY) novaPosicao += new Vector3( 0 , seguir.position.y , 0);

        transform.position = novaPosicao;
    }
}
