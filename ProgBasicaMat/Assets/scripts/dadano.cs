using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dadano : MonoBehaviour
{
    public float dano;
    public bool destroiseAoDarDano;

    protected void OnCollisionEnter2D(Collision2D col) {
        OnTriggerEnter2D(col.collider);
    }

	protected virtual void OnTriggerEnter2D(Collider2D col){
		tomadano t = col.GetComponent<tomadano>();
		
		if(t != null){
			AoDarDano(t);
		}
	}
	
	protected virtual void AoDarDano(tomadano t){
		t.SomaAVida(-dano);
        if (destroiseAoDarDano)
        {
            Destroy(gameObject);
        }
	}
}
