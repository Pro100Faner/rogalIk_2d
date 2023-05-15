using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLvl : MonoBehaviour
{    private GameObject buttonNextLvl;
    private void Start() {
        buttonNextLvl = GameObject.Find("NextLvlButton");
        buttonNextLvl.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player")
        {
            buttonNextLvl.SetActive(true);
        }
    }
     void OnTriggerExit2D(Collider2D other) {
        buttonNextLvl.SetActive(false);
    }
    public void NextLvl(){
        SceneManager.LoadScene("Level");
    }
}
