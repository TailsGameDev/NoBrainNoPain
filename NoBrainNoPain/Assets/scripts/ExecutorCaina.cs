using System.Collections;
using UnityEngine;

class ExecutorCaina : MonoBehaviour {

    [SerializeField] Transform limiteEsq;
    [SerializeField] Transform limiteDir;

    [SerializeField] float velOriginal, velAtual;

    [SerializeField] Rigidbody2D rb2d;

    [SerializeField] PlayerWalk playerWalk;

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
        if ( playerWalk == null){
            GameObject gameObjectPlayer = GameObject.FindGameObjectWithTag("Player");
            if (gameObjectPlayer != null){
                playerWalk = gameObjectPlayer.GetComponent<PlayerWalk>();
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