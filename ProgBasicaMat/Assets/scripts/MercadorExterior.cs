using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercadorExterior : MonoBehaviour
{
    public GameObject mercadorInterior;

    private void OnTriggerEnter2D (Collider2D collision) {
        mercadorInterior.SetActive(true);
    }

    private void OnTriggerExit2D (Collider2D collision) {
        mercadorInterior.SetActive(false);
    }
}
