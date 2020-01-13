using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;

    Rigidbody2D corpo;  

    void Start()
    {
        corpo = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        float inputHorizontal = Input.GetAxis("Horizontal");

        corpo.velocity = new Vector2(inputHorizontal * speed, corpo.velocity.y);

    }

    public void IncreaseSpeed(float amount){
        speed += amount;
    }

}
