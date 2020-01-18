using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    [SerializeField] PlayerWalk playerWalk;
    [SerializeField] DashPlayer dashPlayer;
    [SerializeField] PehPlayer pehPlayer;
    [SerializeField] Ataque ataque;
    [SerializeField] AtaqueEspecial ataqueEspecial;
    [SerializeField] PlayerAnim playerAnim;

    float inputHorizontal;

    private void Update() {
        inputHorizontal = Input.GetAxis("Horizontal");

        GerenciarMovimento();
        GerenciarPulo();
        GerenciarDash();
        GerenciarAnimacao();
        GerenciarAtaque();
        GerenciarAtaqueEspecial();
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
        if (InputAtaqueSimples())
        {
            playerAnim.AnimaAtaqueMelee();
        }
    }

    void GerenciarAtaque(){
        if (InputAtaqueSimples())
        {
            ataque.Atacar();
        }
    }

    void GerenciarAtaqueEspecial(){
        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown("x")){
            ataqueEspecial.TentarAtaqueEspecial();
        }
    }

    bool InputAtaqueSimples(){
        return Input.GetMouseButtonDown(0) || Input.GetKeyDown("z");
    }
}