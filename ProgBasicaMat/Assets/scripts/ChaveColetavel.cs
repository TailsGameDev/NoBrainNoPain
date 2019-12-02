using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaveColetavel : MonoBehaviour
{
    public static bool pegou = false;

    void OnCollisionEnter2D(Collision2D col){
        if(col.collider.tag == "Player"){
            pegou = true;
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
        }
    }

    void OnDisable(){
        pegou = false;
    }
    
}
