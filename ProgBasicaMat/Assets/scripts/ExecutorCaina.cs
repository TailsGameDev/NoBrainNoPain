using System.Collections;
using UnityEngine;

class ExecutorCaina : MonoBehaviour {

    [SerializeField] Transform limiteEsq, limiteDir;

    [SerializeField] float velOriginal, velAtual;

    [SerializeField] Rigidbody2D rb2d;

    [SerializeField] Player player;

    void Start(){
        velAtual = velOriginal;
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2 (velAtual,rb2d.velocity.y);
    }

    void Update(){
        getPlayer();
        Move();
    }

    void getPlayer(){
        if ( player == null){
            GameObject gop = GameObject.FindGameObjectWithTag("Player");
            if (gop != null){
                player = gop.GetComponent<Player>();
            }
        }
    }

    void Move(){
        if ( transform.position.x > limiteDir.position.x){
            velAtual = -velOriginal;
            transform.eulerAngles= new Vector3(0,0,0);
        } else if (transform.position.x < limiteEsq.position.x){
            velAtual = velOriginal;
            transform.eulerAngles= new Vector3(0,180,0);
        }
        rb2d.velocity = new Vector2 (velAtual,rb2d.velocity.y);
    }

    
    public void PausaCaminhada(float tempo){
        StartCoroutine(pausaCaminhada(tempo));
    }

    IEnumerator pausaCaminhada(float tempo){
        float velAnterior = velAtual;
        velAtual = 0;
        yield return new WaitForSeconds(tempo);
        velAtual = velAnterior;
    }
}