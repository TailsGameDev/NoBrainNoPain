﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class proximonivel : MonoBehaviour
{
    public string proximaCena;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag =="Player")
        SceneManager.LoadScene(proximaCena);
    }
}
