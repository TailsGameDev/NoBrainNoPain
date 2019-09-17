using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flechas : MonoBehaviour
{
    Rigidbody2D RP2D;
    public float velocity;

    // Start is called before the first frame update
    void Start()
    {
        RP2D = GetComponent<Rigidbody2D>();
        RP2D.velocity = transform.right*velocity;
        print(transform.forward);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
