using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpot : MonoBehaviour
{
    Camera maincamera;
    static bool trocando = false;

    private void Start () {
        if(maincamera == null) {
            maincamera = Camera.main;
        }
    }

    /*
    private void OnTriggerEnter2D (Collider2D col) {
        if (col.tag == "Player") {
            StartCoroutine(VemCamera());
        }
    }
    */

    public void SejaMinhaCamera () {
        StartCoroutine(VemCamera());
    }

    IEnumerator VemCamera () {
        trocando = true;
            float delay = .3f;
            float t = 0;
            while (t < delay) {
                t += Time.deltaTime;
                maincamera.transform.position = Vector3.Lerp(maincamera.transform.position , transform.position , t);
                yield return null;
            }
            maincamera.transform.position = transform.position;
        trocando = false;
    }
}
