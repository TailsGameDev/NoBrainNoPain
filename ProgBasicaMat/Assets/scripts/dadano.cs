using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dadano : MonoBehaviour
{
    public float dano;
    
	protected void OnTriggerEnter2D(Collider2D col){
		tomadano t = col.GetComponent<tomadano>();
		
		if(t != null){
			AoDarDano(t);
		}
	}
	
	protected virtual void AoDarDano(tomadano t){
		t.SomaAVida(-dano);
		Destroy(gameObject);
	}
}
