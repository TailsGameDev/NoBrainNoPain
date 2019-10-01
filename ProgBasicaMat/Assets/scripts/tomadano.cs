using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomadano : MonoBehaviour
{
	public float vidaMaxima;
    private float vida;
	public vida barraDeVida;
	
	protected virtual void Start(){
		vida = vidaMaxima;
		if (barraDeVida != null){
			barraDeVida.VidaCheia = vidaMaxima;
		}
	}
	
	public void SomaAVida(float qtd){
		vida += qtd;
		
		if (barraDeVida != null){
			barraDeVida.VidaDoPersonagem = vida;
		}
		
		if ( vida <=0 ){
			AoMorrer();
		}
	}
	
	protected virtual void AoMorrer(){
        Destroy(gameObject);
	}
}
