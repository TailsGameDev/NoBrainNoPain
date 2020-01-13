using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAgarra : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col){
        if (col.tag == "Player"){
            transform.position = col.transform.position + new Vector3(0,0,-5);
            GetComponent<Collider2D>().enabled = false;
            StartCoroutine(segue(col));
        }
    }

/*
    void OnTriggerStay2D(Collider2D col){
        if (!seguindo && col.tag == "Player"){
            seguindo = true;
            OnTriggerEnter2D(col);
        }
    }
    */

    IEnumerator segue(Collider2D col){
        while(true){
            if (col == null) break;
            transform.position = col.transform.position + new Vector3(0,0,-5);
            yield return null;
        }
    }
}
