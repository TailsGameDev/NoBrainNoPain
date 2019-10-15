using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosaoTronco : MonoBehaviour
{
    Rigidbody2D player;
    public float forca;

    private void OnCollisionEnter2D (Collision2D col) {
        if (col.collider.tag == "Player") {
            player = col.collider.GetComponent<Rigidbody2D>();
            StartCoroutine(Voa());
        }
    }

    IEnumerator Voa () {
        float t = 0;
        float delay = 1f;
        float forcaInicial = forca;
        float taxaDimForca = -forca/delay;

        while (t < delay) {
            if (player == null) yield break;
            player.velocity = player.velocity - new Vector2(forca , 0);
            forca = forcaInicial + taxaDimForca*t;
            t += Time.deltaTime;
            yield return null;
        }
    }
}
