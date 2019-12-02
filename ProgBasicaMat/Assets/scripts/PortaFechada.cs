using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaFechada : MonoBehaviour
{
    public GameObject chave;
    public float delay;
    
    void OnCollisionEnter2D(Collision2D col){
        if (ChaveColetavel.pegou == false){
            Pisca();
        } else {
            Destroy(gameObject);
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
