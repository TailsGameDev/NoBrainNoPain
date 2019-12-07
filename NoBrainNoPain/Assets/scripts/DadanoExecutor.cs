using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadanoExecutor : dadano
{
    [SerializeField] float delayDestroise;
    void Start(){
        Invoke("Destroise", delayDestroise);
    }

    void Destroise(){
        Destroy(gameObject);
    }
}
