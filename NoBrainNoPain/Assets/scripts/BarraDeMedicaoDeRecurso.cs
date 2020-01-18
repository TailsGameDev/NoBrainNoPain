using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeMedicaoDeRecurso : MonoBehaviour{
	public Image recursoImg;
	public float maximoDeRecurso = 100;
	float larguraOriginalRecursoImg;


	void Awake(){
		larguraOriginalRecursoImg = recursoImg.GetComponent<RectTransform>().sizeDelta.x;
	}

	public void AplicarMelhoria(){
		larguraOriginalRecursoImg *= 1.25f;
		AjustarTamanhoDoPai();
		AjustarTamanho(100);
	}

	void AjustarTamanhoDoPai(){
		RectTransform parentRect = recursoImg.transform.parent.GetComponent<RectTransform>();
		Vector2 tamanhoAntigo = parentRect.sizeDelta;
		Vector2 tamanhoNovo = new Vector2(tamanhoAntigo.x * 1.25f, tamanhoAntigo.y);
		parentRect.sizeDelta = tamanhoNovo;
	}

	public void SetPorcentagem(float porcentagem){

		float porcentagemLimitada = EstabeleceLimitesDaPorcentagem(porcentagem);
		AjustarTamanho(porcentagemLimitada);
	}

	float EstabeleceLimitesDaPorcentagem(float porcentagem){
		float porcentagemLimitada = porcentagem;

		if(porcentagem >= maximoDeRecurso) {
		   	porcentagemLimitada = maximoDeRecurso;
		} else if(porcentagem <= 0) {
		   	porcentagemLimitada = 0;
		}

		return porcentagemLimitada;
	}

	void AjustarTamanho(float porcentagem){
		float porcentagemAjustada = porcentagem / 100; // entre 0 e 1
		float larguraAtual = larguraOriginalRecursoImg * porcentagemAjustada;
		SetTamanhoRecursoImg(larguraAtual);
	}

	void SetTamanhoRecursoImg(float tamanho){
		float yAnterior = recursoImg.GetComponent<RectTransform>().sizeDelta.y;
		Vector2 tamanhoXY = new Vector2(tamanho, yAnterior);
		recursoImg.GetComponent<RectTransform>().sizeDelta = tamanhoXY;
	}
}