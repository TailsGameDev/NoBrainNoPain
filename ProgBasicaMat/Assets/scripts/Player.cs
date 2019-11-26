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
        if (Input.GetKeyDown(KeyCode.W) && podePular)
        {
            corpo.velocity = new Vector2(corpo.velocity.x, forcaPulo);
            podePular = false;

        }
    }

    IEnumerator Voa()
    {
        float t = 0;
        float delay = 1f;
        float forca = Mathf.Abs(forcaInicialDash);

        if (transform.localEulerAngles.y < 0.2f){
            forca = - forca;
            forcaInicialDash = forca;   
        }

        float taxaDimForca = -forca / delay;

        var player = GetComponent<Rigidbody2D>();

        while (t < delay)
        {
            if (player == null) yield break;
            player.velocity = player.velocity - new Vector2(forca, 0);
            forca = forcaInicialDash + taxaDimForca * t;
            t += Time.deltaTime;
            yield return null;
        }
    }

    public void RestauraPulo(){
        forcaPulo = forcaPuloOriginal;
    }
}