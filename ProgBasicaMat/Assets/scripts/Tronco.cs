using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tronco : MonoBehaviour
{
    public Transform paiTronco;
    float z = 90;
    float v = 110f;
    bool teveColisao;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if (teveColisao)
        {
            if (z < -90)
            {
                z = 90;
                teveColisao = false;
            }
            z -= Time.deltaTime * v;
            paiTronco.eulerAngles = new Vector3(0, 0, z);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        OnTriggerEnter2D(col.collider);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
            if (col.tag == "Player")
            {
                teveColisao = true;
            }
    }
}
