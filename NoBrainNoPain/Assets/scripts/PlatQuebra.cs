using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatQuebra : MonoBehaviour
{
    public GameObject platQuebrando;
    private void OnCollisionEnter2D (Collision2D collision) {
        OnTriggerEnter2D(collision.collider);
    }

    private void OnTriggerEnter2D (Collider2D col) {
        if (col.tag == "Player") {
            GetComponent<SpriteRenderer>().color = Color.red;
            Invoke("Quebrar" , 2f);
        }
    }

    void Quebrar () {
        Instantiate(platQuebrando, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
