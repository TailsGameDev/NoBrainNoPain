using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Transform objParaGirar;
    [SerializeField] PlayerWalk playerWalk;
    [SerializeField] PehPlayer pehPlayer;
    [SerializeField] DashPlayer dashPlayer;

    const bool AGARRAR = true;
    const bool SOLTAR = false;

    public void AnimaAoAndar(float inputHorizontal){
        animator.SetFloat("HorizontalAxis", inputHorizontal);
    }

    public void AnimaAtaqueMelee(){
        animator.SetTrigger("ataqueMelee");
    }

    public void OlhaParaOLadoCerto(float inputHorizontal){
        if (inputHorizontal > 0.1)
        {
            objParaGirar.eulerAngles = new Vector3(0, 0, 0);
        }

        if (inputHorizontal < -0.1)
        {
            objParaGirar.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    void Update()
    {
        animator.SetBool("pulo", ! pehPlayer.GetPodePular());
        
        animator.SetBool("dandoDash", dashPlayer.GetDandoDash());
    }

    void OnTriggerEnter2D(Collider2D possivelParede){
        if (EhParede(possivelParede)){
            AgarraOuSoltaParede(possivelParede, AGARRAR);
        }
    }

    void OnTriggerExit2D(Collider2D possivelParede){
        if (EhParede(possivelParede)){
            AgarraOuSoltaParede(possivelParede, SOLTAR);
        }
    }

    bool EhParede(Collider2D possivelParede){
        return possivelParede.tag == "chao";
    }

    void AgarraOuSoltaParede(Collider2D parede, bool EhParaAgarrar){
        if (parede.transform.position.x > transform.position.x){
            animator.SetBool("agarradoEsq", EhParaAgarrar);
        } else {
            animator.SetBool("agarradoEsq", EhParaAgarrar);
        }
    }
}
