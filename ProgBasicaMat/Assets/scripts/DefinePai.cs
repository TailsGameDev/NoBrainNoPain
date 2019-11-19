using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefinePai : MonoBehaviour
{
    public string tagPai;

    void Awake()
    {
        if (tagPai != "") {
            Transform p = GameObject.FindGameObjectWithTag(tagPai).GetComponent<Transform>();
            transform.parent = p;
        } else {
            transform.parent = null;
        }
    }

}
