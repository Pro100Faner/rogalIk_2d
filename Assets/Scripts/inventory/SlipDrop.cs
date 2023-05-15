using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlipDrop : MonoBehaviour
{
    private GameObject player;
    private GameObject gg;
    public Item item;
    public GameObject itemGO;
    public GameObject itemVisual;
    public GameObject Helm;
    public GameObject Armor;
    public GameObject Boots;
    public GameObject Weapon;
    public GameObject Ring;
    public GameObject Amulet;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public void Drop()
    {
        gg = Instantiate(itemGO, player.GetComponent<PlayerMovement>().movePoint.position, Quaternion.identity);
        Destroy(itemVisual);
        gg.GetComponent<InitItem>().itemStat = item;
        gg.GetComponent<InitItem>().createImage(item.itemSprite);
        gameObject.GetComponent<InventoryPanel>().selec_page.SetActive(false);
        gameObject.GetComponent<InventoryPanel>().count -=1;
    }
    public void Slip()
    {
        switch (item.itemType)
        {
            case Item.ItemType.Wepon:
                createDrop(Weapon.GetComponent<EquipItem>().item, Weapon);
                break;
            case Item.ItemType.Armor:
                createDrop(Armor.GetComponent<EquipItem>().item, Armor);
                break;
            case Item.ItemType.Amulet:
                createDrop(Amulet.GetComponent<EquipItem>().item, Amulet);
                break;
            case Item.ItemType.Boots:
                createDrop(Boots.GetComponent<EquipItem>().item, Boots);
                break;
            case Item.ItemType.Helm:
                createDrop(Helm.GetComponent<EquipItem>().item, Helm);
                break;
            case Item.ItemType.Ring:
                createDrop(Ring.GetComponent<EquipItem>().item, Ring);
                break;
        }
    }
    void createDrop(Item i1, GameObject go)
    {
        
        if (i1 != null)
        {   
            go.GetComponent<EquipItem>().UpdateStatsDawn();
            gg = Instantiate(itemGO, player.GetComponent<PlayerMovement>().movePoint.position, Quaternion.identity);
            gg.GetComponent<InitItem>().itemStat = i1;
            gg.GetComponent<InitItem>().createImage(i1.itemSprite);
        }
        go.GetComponent<Image>().sprite = item.itemSprite;
        go.GetComponent<EquipItem>().item = item;
        go.GetComponent<EquipItem>().UpdateStatsUP();
        Destroy(itemVisual);
        gameObject.GetComponent<InventoryPanel>().selec_page.SetActive(false);
        gameObject.GetComponent<InventoryPanel>().count -=1;

    }
}
