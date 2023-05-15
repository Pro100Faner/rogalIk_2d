using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPanel : MonoBehaviour
{
    public GameObject itemVisualPrefab;
    public Transform ItemTab;
    public GameObject inventPanel;
    public GameObject selec_page;
    public GameObject[] selec_page_list;
    public GameObject buttonTake;
    public int count = 0;
    private void Start()
    {
        inventPanel.SetActive(false);
    }
    public void CloseOpenPanel()
    {
        inventPanel.SetActive(!inventPanel.activeInHierarchy);
        if (selec_page.activeInHierarchy == true)
        {
            selec_page.SetActive(false);
        }
    }
    public void AddItem(GameObject go)
    {
        GameObject newItem = Instantiate(itemVisualPrefab, Vector3.zero, Quaternion.identity, ItemTab);
        newItem.GetComponent<ItemVisual>().AddItem(go);
        count += 1;
    }
    
}
