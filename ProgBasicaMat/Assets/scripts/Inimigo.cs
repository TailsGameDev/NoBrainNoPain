using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{ 
     public GameObject estocada, pontaDaLanca;
    protected bool eLadoDireito;
    [SerializeField] protected float speed;
    protected float speedOriginal;
    protected Animator anim;
    protected bool atacando = false;

    // Start is called before the first frame update
    protected void Start()
    {
        speedOriginal = speed;
        eLadoDireito = true;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Mover();
       
    }
    protected void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !atacando)
        {
            Atacar();
        }
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Limite")
        {
            MudarDirecao();
        }
        if (collision.tag == "Player")
        {
            Atacar();
        }
    }

    protected void Mover()
    {
        transform.Translate(PegarDirecao() * (speed * Time.deltaTime));
    }



    //m
   

    protected Vector2 PegarDirecao()
    {
        return eLadoDireito ? Vector2.right : Vector2.left;
    }

    protected void MudarDirecao()
    {
        eLadoDireito = !eLadoDireito;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);

    }

    protected void Atacar()
    {
        atacando = true;
        speed = 0;
        anim.SetBool("atacando", true);
        Invoke("CriaEstocada", 0.8f);
        Invoke("voltarAoNormal", 1.2f);
        Invoke("setBoolFalse", 0.2f);
    }

    protected void CriaEstocada()
    {
        GameObject Estocada = Instantiate(estocada, pontaDaLanca.transform.position, pontaDaLanca.transform.rotation);
       
    }

    protected  void setBoolFalse()
    {
        anim.SetBool("atacando", false);
    }
    protected void voltarAoNormal ()
    {
        speed = speedOriginal;
        atacando = false;
    }
}
