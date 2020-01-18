using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    [SerializeField] GameObject pontoDeOrigem;
    [SerializeField] GameObject colisor;

    public void Atacar(){
        Instantiate(colisor,
            pontoDeOrigem.transform.position,
            pontoDeOrigem.transform.rotation
        );
    }

}