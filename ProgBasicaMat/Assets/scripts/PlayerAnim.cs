using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    Animator animator;
    public Transform objParaGirar;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if (objParaGirar == null) {
            objParaGirar = transform.parent;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        animator.SetFloat("HorizontalAxis", h);

        if (h > 0.1)
        {
            objParaGirar.eulerAngles = new Vector3(0, 0, 0);
        }

        if (h < -0.1)
        {
            objParaGirar.eulerAngles = new Vector3(0, 180, 0);
        }
        
    }

}
