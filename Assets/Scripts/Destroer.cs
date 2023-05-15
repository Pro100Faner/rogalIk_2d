using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "SpawnPoint")
        Destroy(other.gameObject);
        else if(other.name == "destoerrr"){
           Destroy(other.gameObject.transform.parent.gameObject);
        }
    }
}
