using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool podePular;
    Rigidbody2D corpo;
    public float speed = 5, horiDirect, VerDirect, forcaPulo;
    float forcaPuloOriginal;
    public float forcaInicialDash;
    public bool dandoDash = false;

    // Start is called before the first frame update
    void Start()
    {
        forcaPuloOriginal = forcaPulo;
        int joelhoQtdd = Comprou.joelho;
        if (joelhoQtdd < 1){
            forcaPulo = 0;
        }

        int pesQtdd = Comprou.pes;
        while (pesQtdd > 0)
        {
            speed += 1;
            pesQtdd -= 1;
        }
        corpo = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        horiDirect = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(Voa());
        }

        corpo.velocity = new Vector2(horiDirect * speed, corpo.velocity.y);
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && podePular)
        {
            corpo.velocity = new Vector2(corpo.velocity.x, forcaPulo);
            podePular = false;

        }
    }

    IEnumerator Voa()
    {
        if (Comprou.pes > 0 && (! dandoDash)){
            dandoDash = true;
            float t = 0;
            float delay = .5f;

            bool direita = transform.localEulerAngles.y < 0.2f;

            int mult = 1;
            if ( ! direita ){
                mult = -1;
            }

            while (t < delay)
            {
                corpo.velocity = new Vector2(10*mult, 0);
                t += Time.deltaTime;
                yield return null;
            }
            dandoDash = false;
        }
    }

    public void RestauraPulo(){
        forcaPulo = forcaPuloOriginal;
    }
}