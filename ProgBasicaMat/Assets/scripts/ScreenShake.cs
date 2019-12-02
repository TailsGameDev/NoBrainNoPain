using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public int qtdPontos;
    public int range;
    public float duracao;
    // Start is called before the first frame update
    
    public void Shake(){
        StartCoroutine(shake());
    }
    IEnumerator shake(){
        Vector3[] pontos = new Vector3[qtdPontos];
        float myRange = range;
        for (int i = 0; i < qtdPontos; i++)
        {
            pontos[i] = 0.01f*(new Vector3(
                Random.Range(-myRange,myRange), Random.Range(-myRange,myRange),0));
            pontos[i] += transform.position; //assume que o script tah na camera
            myRange = range*(qtdPontos - i)/qtdPontos;
        }

        float t = 0;
        int k = 0;
        pontos[0] = transform.position;
        pontos[qtdPontos-1] = transform.position;
        GameObject playerGO = GameObject.FindGameObjectWithTag("Player");
        Transform player;
        if (playerGO != null){
            player = playerGO.transform;
        } else {
            player = transform;
        }
        while (t < duracao && k < qtdPontos-1){
            t += Time.deltaTime;
            float x = Mathf.Lerp(pontos[k].x, pontos[k+1].x, t/duracao);
            float y = Mathf.Lerp(pontos[k].y, pontos[k+1].y, t/duracao);
            if (player != null){
                pontos[qtdPontos-1] = player.position;
            }
            transform.position = new Vector3(x,y,-5);
            if (t >= duracao){
                k+=1;
                t = 0;
            }
            yield return null;
        }
    }
}
