using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour
{
    public List<GameObject> dontDestr;
    private void Start() 
    {
        foreach (GameObject item in dontDestr)
        {
            if (item.name != "dDestrList")
            item.SetActive(false);
        }
    }

    public void Load(){
        SceneManager.LoadScene("SelectHero");
        foreach (GameObject item in dontDestr)
        {
            DontDestroyOnLoad(item);
        }
    }
}
