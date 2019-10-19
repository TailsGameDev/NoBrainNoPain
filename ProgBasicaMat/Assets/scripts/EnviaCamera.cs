using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviaCamera : MonoBehaviour
{
    CameraSpot toOlhando;

    private void OnTriggerStay2D (Collider2D col) {
        CameraSpot devoOlhar = col.GetComponent<CameraSpot>();

        if (devoOlhar != null) {
            if (devoOlhar != toOlhando) {
                devoOlhar.SejaMinhaCamera();
                toOlhando = devoOlhar;
            }
        }

    }
}
