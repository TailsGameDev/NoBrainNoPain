using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeExecutor : MonoBehaviour
{
    [SerializeField] float delayAtk;
    [SerializeField] float delayCaminhada;
    [SerializeField] GameObject dadanoExecutor;
    [SerializeField] Animator animator;
    [SerializeField] ExecutorCaina executorCaina;
    [SerializeField] bool atacando;

    void OnTriggerStay2D(Collider2D col){
        if (col.tag=="Player" && !atacando){
            OnTriggerEnter2D(col);
        }
    }
    void OnTriggerEnter2D(Collider2D col){
        if (col.tag == "Player" && !atacando){
            atacando = true;
            executorCaina.PausaCaminhada(delayCaminhada-0.02f);
            animator.SetTrigger("atacar");
            Invoke("InstanciaDadano", delayAtk);
            Invoke("FimAtaque", delayCaminhada);
        }
    }

    void InstanciaDadano(){
        Instantiate(dadanoExecutor, transform.position, Quaternion.identity);
    }
    void FimAtaque(){
        atacando = false;
    }
}
