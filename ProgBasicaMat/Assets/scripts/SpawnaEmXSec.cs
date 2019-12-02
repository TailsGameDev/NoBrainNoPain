using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnaEmXSec : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] float tempoParaSpawnar;
    [SerializeField] float chancePorCento;
    void Start()
    {
        int num = Random.Range(0,100);
        if (num >= chancePorCento){
            Invoke("spawna",tempoParaSpawnar);
        }
    }

    public void spawna(){
        Instantiate(obj, transform.position, Quaternion.identity);
    }
}
