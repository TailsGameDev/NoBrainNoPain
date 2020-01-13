using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PehPlayer : MonoBehaviour
{
    [SerializeField] Player player;
    
    private bool podePular;
    [SerializeField] float forcaPulo;
    float forcaPuloOriginal;

    Rigidbody2D corpo;

    private void Start () {
        forcaPuloOriginal = forcaPulo;

        DesabilitaPuloSeNaoComprouJoelho();

        corpo = player.GetComponent<Rigidbody2D>();
    }

    void DesabilitaPuloSeNaoComprouJoelho(){
        int joelhosComprados = Comprou.joelho;
        if (joelhosComprados < 1){
            forcaPulo = 0;
        }
    }

    private void Update() {
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && podePular)
        {
            Pular();
        }
    }

    void Pular(){
        corpo.velocity = new Vector2(corpo.velocity.x, forcaPulo);
        podePular = false;
    }

    private void OnTriggerStay2D (Collider2D coll) {
        if (coll.gameObject.tag == "chao") {
            podePular = true;
        }
    }
    private void OnTriggerExit2D (Collider2D coll) {
        if (coll.gameObject.tag == "chao") {
            podePular = false;
        }
    }

    public void RestauraPulo(){
        forcaPulo = forcaPuloOriginal;
    }

    public bool GetPodePular(){
        return podePular;
    }
}
