using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject mordida;
    public GameObject Boca;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1)) {
            GameObject Mordida = Instantiate(mordida, Boca.transform.position, Boca.transform.rotation);
        }
    }
}