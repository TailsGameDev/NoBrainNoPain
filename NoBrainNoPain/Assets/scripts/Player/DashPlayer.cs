using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPlayer : MonoBehaviour
{
    [SerializeField] float velocidadeEmModulo;
    [SerializeField] float duracao;


    Rigidbody2D corpo;
    bool dandoDash = false;
    private float velocidadeComSinal;
    private float tempoAtual;

    private void Start() {
        corpo = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && PodeDarDash())
        {
            Dash();
        }
    }

    bool PodeDarDash(){
        return Comprou.pes > 0 && (! dandoDash);
    }

    void Dash()
    {
        InicializaDash();
        StartCoroutine(DashLoop());
        StartCoroutine(EncerraDashAoAcabar());
    }

    void InicializaDash(){
        dandoDash = true;
        tempoAtual = 0;
        velocidadeComSinal = CalcularVelocidadeComSinal();
    }

    IEnumerator DashLoop(){
        while (tempoAtual < duracao)
        {
            corpo.velocity = new Vector2(velocidadeComSinal, 0);
            tempoAtual += Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator EncerraDashAoAcabar(){
        yield return new WaitForSeconds(duracao);
        dandoDash = false;
    }

    float CalcularVelocidadeComSinal(){
        float velocidade;
        if (EstahOlhandoParaDireita()){
            velocidade = velocidadeEmModulo;
        } else {
            velocidade = -velocidadeEmModulo;
        }
        return velocidade;
    }

    bool EstahOlhandoParaDireita(){
        return transform.localEulerAngles.y < 0.2f;
    }

    public bool GetDandoDash(){
        return dandoDash;
    }
}
