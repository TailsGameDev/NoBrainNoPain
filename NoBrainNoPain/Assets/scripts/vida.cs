using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vida : MonoBehaviour{
	public float VidaDoPersonagem;
	//public Texture Sangue,Contorno;
	public Image sangue;
	public float VidaCheia = 100;
	float larguraSangueOriginal;
    public bool aumentado;

	void Start (){
        VidaDoPersonagem = VidaCheia;
        larguraSangueOriginal = sangue.GetComponent<RectTransform>().sizeDelta.x; //aqui
        StartCoroutine(AjustaTamanho());
	}

    IEnumerator AjustaTamanho () {
        yield return null;
        VidaDoPersonagem = VidaCheia;
        larguraSangueOriginal = sangue.GetComponent<RectTransform>().sizeDelta.x; //aqui
    }

	void Update (){

        if (aumentado) {
            larguraSangueOriginal *= 1.25f;
            aumentado = false;
            transform.parent.GetComponent<RectTransform>().sizeDelta =
                new Vector2(
                    transform.parent.GetComponent<RectTransform>().sizeDelta.x *1.25f,
                    transform.parent.GetComponent<RectTransform>().sizeDelta.y
                );
        }

		if(VidaDoPersonagem >= VidaCheia) {
		   VidaDoPersonagem = VidaCheia;
		} else if(VidaDoPersonagem <= 0) {
		   VidaDoPersonagem = 0;
		}
		//aqui
		sangue.GetComponent<RectTransform>().sizeDelta = 
		new Vector2 (VidaDoPersonagem * larguraSangueOriginal / VidaCheia,sangue.GetComponent<RectTransform>().sizeDelta.y) ;
	}
	/*
	void OnGUI (){
		GUI.DrawTexture(new rect(Screen.width/40,Screen.height/40,Screen.width/5,Screen.height/8),Contorno);
	}
	*/
}