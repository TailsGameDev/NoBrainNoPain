using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtritoPlatMovelComPlayer : MonoBehaviour
{
    Transform jogador;
    private void OnTriggerStay2D (Collider2D peh) {
        if (EhOPehDoJogador(peh)) {
            jogador = peh.transform.parent;
            jogador.parent = this.transform;
        }
    }

    private void OnTriggerExit2D (Collider2D peh) {
        if (EhOPehDoJogador(peh)) {
            jogador.parent = null;
        }
    }

    bool EhOPehDoJogador(Collider2D peh){
        return peh.GetComponent<PehPlayer>() != null;
    }

}
