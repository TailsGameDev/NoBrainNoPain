using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaFechada : MonoBehaviour
{
    public GameObject chave;
    public GameObject portaAberta;
    public float delay;
    
    void OnTriggerEnter2D(Collider2D col){
        if (col.tag == "Player"){
            if (ChaveColetavel.pegou == false){
                Pisca();
            } else {
                portaAberta.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
    public void Pisca(){
        StartCoroutine(pisca());
    }
    IEnumerator pisca(){
        chave.SetActive(true);
        yield return new WaitForSeconds(delay);
        chave.SetActive(false);
        yield return new WaitForSeconds(delay);
        chave.SetActive(true);
        yield return new WaitForSeconds(delay);
        chave.SetActive(false);
    }
}
