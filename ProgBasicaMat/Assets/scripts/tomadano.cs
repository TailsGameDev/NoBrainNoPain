using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomadano : MonoBehaviour
{
    public string identificador;
	public float vidaMaxima;
    private float vida;
	public vida barraDeVida;
    [SerializeField] GameObject criaAoMorrer;

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
        if (criaAoMorrer != null) Instantiate(criaAoMorrer, transform.position, transform.rotation);
        Destroy(gameObject);
	}
    
    
         

}
