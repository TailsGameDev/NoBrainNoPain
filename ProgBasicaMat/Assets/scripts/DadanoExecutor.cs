using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadanoExecutor : dadano
{
    void Start(){
        Invoke("Destroise", 1f);
    }

    void Destroise(){
        Destroy(gameObject);
    }
}
