using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomadano : MonoBehaviour
{
	[SerializeField] ParticleSystem particles;
    public string identificador;
	public float vidaMaxima;
    [SerializeField] protected float vida;
	public BarraDeMedicaoDeRecurso barraDeVida;
    [SerializeField] GameObject criaAoMorrer;

	protected virtual void Start(){
		vida = vidaMaxima;
	}
	
	public virtual void SomaAVida(float qtd){
		if (qtd < 0 && particles != null){
			particles.Play();
		}
		
		vida += qtd;
		
        if(vida > vidaMaxima) {
            vida = vidaMaxima;
        }

		if (barraDeVida != null){
			float porcentagemVida = 100*vida/vidaMaxima;
			barraDeVida.SetPorcentagem(porcentagemVida);
		}
		
		if ( vida <=0 ){
			AoMorrer();
		}
	}
	
	protected virtual void AoMorrer(){
        if (criaAoMorrer != null) Instantiate(criaAoMorrer, transform.position, transform.rotation);
        Destroy(gameObject);
	}
    
    
         

}
