using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    Animator animator;
    public Transform objParaGirar;
    [SerializeField] Player player;
    PehPlayer pehPlayer;
    DashPlayer dashPlayer;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if (objParaGirar == null) {
            objParaGirar = transform.parent;
        }
        if (player == null)
        {
            player = transform.parent.GetComponent<Player>();
        }
        pehPlayer = player.GetComponentInChildren<PehPlayer>();
        dashPlayer = player.GetComponent<DashPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("dandoDash", dashPlayer.GetDandoDash());

        float h = Input.GetAxis("Horizontal");

        animator.SetFloat("HorizontalAxis", h);

        if (h > 0.1)
        {
            objParaGirar.eulerAngles = new Vector3(0, 0, 0);
        }

        if (h < -0.1)
        {
            objParaGirar.eulerAngles = new Vector3(0, 180, 0);
        }
        animator.SetBool("pulo", ! pehPlayer.GetPodePular());

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("z"))
        {
            animator.SetTrigger("Mordida");
        }

    }


    void OnTriggerEnter2D(Collider2D col){
        if (col.tag == "chao"){
            if (col.transform.position.x > transform.position.x){
                animator.SetBool("agarradoEsq", true);
            } else {
                animator.SetBool("agarradoEsq", true);
            }
        }
    }
    void OnTriggerExit2D(Collider2D col){
        if (col.tag == "chao"){
            if (col.transform.position.x > transform.position.x){
                animator.SetBool("agarradoEsq", false);
            } else {
                animator.SetBool("agarradoEsq", false);
            }
        }
    }
}
