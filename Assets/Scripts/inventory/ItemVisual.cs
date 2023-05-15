using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemVisual : MonoBehaviour
{
    private GameObject selec_page;
    private GameObject[] invSelect;
    private InventoryPanel inv_invPanel;
    private SlipDrop inv_slipDrop;
    public Item item1;
    private void Awake()
    {
        GameObject canv;
        canv = GameObject.Find("Canvas");
        inv_invPanel = canv.GetComponent<InventoryPanel>();
        inv_slipDrop = canv.GetComponent<SlipDrop>();
        selec_page = inv_invPanel.selec_page;
        invSelect = inv_invPanel.selec_page_list;
    }
    public void AddItem(GameObject go)
    {
        item1 = go.GetComponent<InitItem>().itemStat;
        GetComponent<Image>().sprite = go.GetComponent<SpriteRenderer>().sprite;
    }

    private void select()
    {
        
        foreach (GameObject item in invSelect)
        {
            if (item.name == "Image")
            {
                item.GetComponent<Image>().sprite = item1.itemSprite;
            }
            else if (item.name == "itemDescription")
            {
                item.GetComponent<Text>().text = item1.itemDescription;
            }
            else if (item.name == "itemName")
            {
                item.GetComponent<Text>().text = item1.itemName;
            }
        }
        if (selec_page.activeInHierarchy == false)
            selec_page.SetActive(true);
        inv_slipDrop.item = item1;
        inv_slipDrop.itemVisual = gameObject;
    }
}
