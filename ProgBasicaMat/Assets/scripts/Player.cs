using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool podePular;
    Rigidbody2D corpo;
    public float speed = 5, horiDirect, VerDirect, forcaPulo;

    // Start is called before the first frame update
    void Start()
    {
        corpo = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        horiDirect = Input.GetAxis("Horizontal");

        corpo.velocity = new Vector2(horiDirect * speed, corpo.velocity.y);
        if (Input.GetKeyDown(KeyCode.W) && podePular)
        {
            corpo.velocity = new Vector2(corpo.velocity.x, forcaPulo);
            podePular = false;

        }
    }

}