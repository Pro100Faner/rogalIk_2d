using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    private GameObject mainCam;
    void Start()
    {
        mainCam = GameObject.Find("Main Render");
        mainCam.SetActive(false);
        StartCoroutine(LoadScrean());
    }
    IEnumerator LoadScrean(){
        yield return new WaitForSeconds(5f);
        mainCam.SetActive(true);
        Destroy(gameObject);
    }
}
