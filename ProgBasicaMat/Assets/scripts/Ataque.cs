using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    public int Dano;
    bool ataque;
    Animator animator;
    GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject g = animator.gameObject;
        //go.GetComponent<Animator>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"));
       
    }
}
