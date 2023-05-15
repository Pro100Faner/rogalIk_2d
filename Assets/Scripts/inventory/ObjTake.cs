using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjTake : MonoBehaviour
{
    public GameObject item;
    private GameObject button;
    void Start()
    {
        button = GameObject.Find("Canvas").GetComponent<InventoryPanel>().buttonTake;
        button.GetComponent<Button>().onClick.AddListener(Add);
        Close();
    }

    public void Aktivate(){
        button.SetActive(true);
    }
    public void Close(){
        button.SetActive(false);
    }
    public void Add(){
        item.GetComponent<Take>().Takeitem();
        
    }


}
