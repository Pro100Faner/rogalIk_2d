using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.Animations;
public class StartGameHero : MonoBehaviour
{
    public AnimatorController animator;
    private GameObject player;
    private GameObject dontDestrScan;
    public Sprite image;
    
    void Start()
    {
        dontDestrScan = GameObject.Find("dDestrList");
        player = dontDestrScan.GetComponent<DontDestr>().PlayerPref;
    }
    public void StartGame(){
        GameObject gg = Instantiate(player, Vector3.zero, Quaternion.identity);
        DontDestroyOnLoad(gg.GetComponent<PlayerMovement>().movePoint);
        DontDestroyOnLoad(gg);
        foreach (GameObject go in dontDestrScan.GetComponent<DontDestr>().dDestrList)
        {
            go.SetActive(true);
        }
        dontDestrScan.GetComponent<DontDestr>().camer.GetComponent<Cinemachine.CinemachineVirtualCamera>().Follow = gg.transform;
        SceneManager.LoadScene("Level");

    }
}
