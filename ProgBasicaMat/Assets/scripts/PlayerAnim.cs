using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        animator.SetFloat("HorizontalAxis", h);

        if (h > 0.1)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (h < -0.1)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
    
}
