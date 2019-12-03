using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{
    Animator animator;
    [SerializeField] Menu menu;
    [SerializeField] string nextScene;
    bool tahCarregando = false;
    void Start(){
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (tahCarregando) return;

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Acabou")){
            tahCarregando = true;
            menu.GoToScene(nextScene);
        }
    }
}
