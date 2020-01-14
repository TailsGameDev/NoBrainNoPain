using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    [SerializeField] PlayerWalk playerWalk;
    [SerializeField] DashPlayer dashPlayer;
    [SerializeField] PehPlayer pehPlayer;
    [SerializeField] Ataque ataque;
    [SerializeField] PlayerAnim playerAnim;

    float inputHorizontal;

    private void Update() {
        inputHorizontal = Input.GetAxis("Horizontal");

        GerenciarMovimento();
        GerenciarPulo();
        GerenciarDash();
        GerenciarAnimacao();
        GerenciarAtqMelee();
        GerenciarAtqRanged();
    }

    void GerenciarMovimento(){
        playerWalk.Walk(inputHorizontal);
    }

    void GerenciarPulo(){
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
            pehPlayer.TentarPular();
        }
    }

    void GerenciarDash(){
        if (Input.GetKey(KeyCode.Space)){
            dashPlayer.TentarDash();
        }
    }

    void GerenciarAnimacao(){
        playerAnim.AnimaAoAndar(inputHorizontal);
        playerAnim.OlhaParaOLadoCerto(inputHorizontal);
        if (QuerAtacarMelee())
        {
            playerAnim.AnimaAtaqueMelee();
        }
    }

    void GerenciarAtqMelee(){
        if (QuerAtacarMelee())
        {
            ataque.TentarAtaqueMelee();
        }
    }

    void GerenciarAtqRanged(){
        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown("x")){
            ataque.TentarAtaqueRanged();
        }
    }

    bool QuerAtacarMelee(){
        return Input.GetMouseButtonDown(0) || Input.GetKeyDown("z");
    }
}