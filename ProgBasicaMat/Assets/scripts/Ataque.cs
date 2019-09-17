using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    public GameObject Square;
    private float i;
    //class PosicionaPlayer;
    public GameObject Boca;
    // Start is called before the first frame update
    void Start()
    {
        GameObject vomito = Instantiate(Square, Boca.transform.position, Quaternion.identity);
        //vomito.transform.position = Bo
        //Transform.<PosicionaPlayer>;
       
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}