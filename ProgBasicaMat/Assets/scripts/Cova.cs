using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cova : MonoBehaviour
{

    public float delay;
    public GameObject player;
    public Transform spawnPoint;

    void Start()
    {
        //if (player == null) player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        delay -= Time.deltaTime;
        if (delay <= 0) {
            Instantiate(player , spawnPoint.position , Quaternion.identity);
            enabled = false;
        }
    }
}
