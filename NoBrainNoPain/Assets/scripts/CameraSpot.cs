using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpot : MonoBehaviour
{
    Camera maincamera;

    private void Start () {
        if(maincamera == null) {
            maincamera = Camera.main;
        }
    }

    
    private void OnTriggerEnter2D (Collider2D col) {
        if (col.tag == "cova") {
            maincamera.transform.position = transform.position;
        }
    }

    public void SejaMinhaCamera () {
        if(maincamera.GetComponent<CameraAgarra>() == null){ //se tem componente, camera segue sempre
            StartCoroutine(VemCamera());
        }
    }

    IEnumerator VemCamera () {
        float delay = .3f;
        float t = 0;
        while (t < delay) {
            t += Time.deltaTime;
            maincamera.transform.position = Vector3.Lerp(maincamera.transform.position , transform.position , t);
            yield return null;
        }
        maincamera.transform.position = transform.position;
    }
}
