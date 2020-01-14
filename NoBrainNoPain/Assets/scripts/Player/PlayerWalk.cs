using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] float speed;

    Rigidbody2D corpo;  

    void Start()
    {
        corpo = gameObject.GetComponent<Rigidbody2D>();
    }

    public void Walk(float inputHorizontal)
    {
        corpo.velocity = new Vector2(inputHorizontal * speed, corpo.velocity.y);
    }

    public void IncreaseSpeed(float amount){
        speed += amount;
    }

}
