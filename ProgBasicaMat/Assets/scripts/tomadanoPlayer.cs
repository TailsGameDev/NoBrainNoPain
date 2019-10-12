using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomadanoPlayer : tomadano
{
    // Start is called before the first frame update
    protected override void Start()
    {
        if (barraDeVida == null) {
            if (GameObject.FindGameObjectWithTag("barraVidaPlayer") != null) {
                barraDeVida = GameObject.FindGameObjectWithTag("barraVidaPlayer").GetComponent<vida>();
            }
        }

        base.Start();
    }

    protected override void AoMorrer () {
        Morte.PlayerMorre();
        base.AoMorrer();
    }
}
