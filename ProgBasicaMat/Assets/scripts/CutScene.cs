using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{
    Animator animator;
    [SerializeField] Menu menu;
    [SerializeField] string nextScene;
    void Start(){
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Acabou")){
            menu.GoToScene(nextScene);
        }
    }
}
