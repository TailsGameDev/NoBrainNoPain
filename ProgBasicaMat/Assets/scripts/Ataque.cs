﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Essa classe estah meio que fazendo uma função de ataque Ranged para o Player.
// Talvez possa ser usada no futuro para fazer ataque de inimigos também.
public class Ataque : MonoBehaviour
{
    public GameObject Vomito; //o vomito em si, que por si soh jah se move.
    public GameObject Boca; //spawn point do vomito

    private void Update () {
        if (Input.GetKeyDown("v")) {
            GameObject vomito = Instantiate(Vomito, Boca.transform.position, Boca.transform.rotation);
        }
    }
}