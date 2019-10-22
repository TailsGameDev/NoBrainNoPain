using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraDeVomito : MonoBehaviour
{
    GameObject = barraVomito;
    public float BarraDoPersonagem;
    public RawImage barraVomito;
    public float BaraCheia = 5;
    float larguraBarraOriginal;
    void Start()
    {
        
        BarraDoPersonagem = BaraCheia;
        larguraBarraOriginal = barraVomito.GetComponent<RawImage>().sizeDelta.x;


    }
    void Update()
    {

        if (BarraDoPersonagem >= BaraCheia)
        {
            BarraDoPersonagem = BaraCheia;
        }
        else if (BarraDoPersonagem <= 0)
        {
            BarraDoPersonagem = 0;
        }
        //aqui
        barraVomito.GetComponent<rawimage>().sizeDelta =
        new Vector2(BarraDoPersonagem * larguraBarraOriginal / BaraCheia, barraVomito.GetComponent<Rawimage>().sizeDelta.x);
    }
}
