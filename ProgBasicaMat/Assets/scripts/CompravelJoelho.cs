using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompravelJoelho : Compravel
{
    // Start is called before the first frame update
    public int qtdLimite;

    private void Start () {
        if (Comprou.coracoes >= qtdLimite) {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    protected override void Efeito(){
        Comprou.joelho += 1;
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        player.RestauraPulo();
    }
}
