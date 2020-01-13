using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detecçãodaflecha : MonoBehaviour
{

    public GameObject flecha;
    public Transform spawn;
    public Animator anim;

    void OnCollisionEnter2D(Collision2D col)
    {
        OnTriggerEnter2D(col.collider);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            anim.SetTrigger("atirou");

            Invoke("atira",0.5f);
        }
    }

    void atira()
    {
        Instantiate(flecha, spawn.position, spawn.rotation);
    }

}
