using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestr : MonoBehaviour
{
    public List<GameObject> dDestrList;
    public GameObject PlayerPref;
    public GameObject camer;
    
    void Start()
    {
        dDestrList = GameObject.Find("Underworld").GetComponent<NextLvl>().dontDestr;
    }
}
