using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{ 
    public GameObject estocada, pontaDaLanca;
    private bool eLadoDireito;
    [SerializeField] private float speed;
    float speedOriginal;
    Animator anim;
    bool atacando = false;

    // Start is called before the first frame update
    void Start()
    {
        speedOriginal = speed;
        eLadoDireito = true;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
       
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !atacando)
        {
            Atacar();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
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

    void Mover()
    {
        transform.Translate(PegarDirecao() * (speed * Time.deltaTime));
    }



    //m
    void continuarDano()
    {
      

    }

    private Vector2 PegarDirecao()
    {
        return eLadoDireito ? Vector2.right : Vector2.left;
    }

    void MudarDirecao()
    {
        eLadoDireito = !eLadoDireito;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);

    }

    private void Atacar()
    {
        atacando = true;
        speed = 0;
        anim.SetBool("atacando", true);
        Invoke("CriaEstocada", 0.8f);
        Invoke("voltarAoNormal", 1.2f);
        Invoke("setBoolFalse", 0.2f);
    }

    void CriaEstocada()
    {
        GameObject Estocada = Instantiate(estocada, pontaDaLanca.transform.position, pontaDaLanca.transform.rotation);
       
    }

    void setBoolFalse()
    {
        anim.SetBool("atacando", false);
    }
    void voltarAoNormal ()
    {
        speed = speedOriginal;
        atacando = false;
    }
}
