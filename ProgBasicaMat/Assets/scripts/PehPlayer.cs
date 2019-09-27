using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PehPlayer : MonoBehaviour
{
    [SerializeField] Player player;
    private void Start () {
        if (player == null) {
            player = transform.parent.GetComponent<Player>();
        }
    }

    private void OnTriggerStay2D (Collider2D coll) {
        if (coll.gameObject.tag == "chao") {
            player.podePular = true;
            player.transform.parent = coll.transform; //personagem se move junto com plataformas moveis
        }
    }
    private void OnTriggerExit2D (Collider2D coll) {
        if (coll.gameObject.tag == "chao") {
            player.podePular = false;
            player.transform.parent = null;
        }
    }
}
