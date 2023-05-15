using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitItem : MonoBehaviour
{
    public Item itemStat;
    public List<Sprite> spritesHelm;
    public List<Sprite> spritesArmor;
    public List<Sprite> spritesBoots;
    public List<Sprite> spritesWeapon;
    public List<Sprite> spritesRing;
    public List<Sprite> spritesAmulet;
    public List<Sprite> spritesUsableItem;
    public Item create()
    {
        int ident = Random.Range(0, 7);
        switch (ident)
        {
            case 0:
                List<Atributs> atributsWeapon = new List<Atributs>();
                atributsWeapon.Add(new Atributs(Atributs.Stat.damage, Random.Range(10, 40)));
                atributsWeapon.Add(new Atributs(Atributs.Stat.attakSpeead, 1));
                itemStat = createDescr(Item.ItemType.Wepon, atributsWeapon, spritesWeapon);
                break;
            case 1:
                List<Atributs> atributsArmor = new List<Atributs>();
                atributsArmor.Add(new Atributs(Atributs.Stat.deffens, Random.Range(5, 10)));
                atributsArmor.Add(new Atributs(Atributs.Stat.Healse, Random.Range(50, 200)));
                itemStat = createDescr(Item.ItemType.Armor, atributsArmor, spritesArmor);
                break;
            case 2:
                List<Atributs> atributsHelm = new List<Atributs>();
                atributsHelm.Add(new Atributs(Atributs.Stat.deffens, Random.Range(3, 15)));
                atributsHelm.Add(new Atributs(Atributs.Stat.Healse, Random.Range(20, 100)));
                itemStat = createDescr(Item.ItemType.Helm, atributsHelm, spritesHelm);
                break;
            case 3:
                List<Atributs> atributsBoots = new List<Atributs>();
                atributsBoots.Add(new Atributs(Atributs.Stat.deffens, Random.Range(3, 15)));
                atributsBoots.Add(new Atributs(Atributs.Stat.Healse, Random.Range(20, 100)));
                itemStat = createDescr(Item.ItemType.Boots, atributsBoots, spritesBoots);
                break;
            case 4:
                List<Atributs> atributsRing = new List<Atributs>();
                atributsRing.Add(new Atributs(Atributs.Stat.deffens, Random.Range(3, 15)));
                atributsRing.Add(new Atributs(Atributs.Stat.Healse, Random.Range(20, 100)));
                itemStat = createDescr(Item.ItemType.Ring, atributsRing, spritesRing);
                break;
            case 5:
                List<Atributs> atributsAmulet = new List<Atributs>();
                atributsAmulet.Add(new Atributs(Atributs.Stat.deffens, Random.Range(3, 15)));
                atributsAmulet.Add(new Atributs(Atributs.Stat.Healse, Random.Range(20, 100)));
                itemStat = createDescr(Item.ItemType.Amulet, atributsAmulet, spritesAmulet);
                break;
            case 6:
                List<Atributs> atributsUsadle = new List<Atributs>();
                atributsUsadle.Add(new Atributs(Atributs.Stat.hpHeal, 30));
                itemStat = createDescr(Item.ItemType.UsableItem, atributsUsadle, spritesUsableItem);
                break;
        }
        return itemStat;
    }

    public void createImage(Sprite _image)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _image;
    }
    private Item createDescr(Item.ItemType type, List<Atributs> atributs, List<Sprite> sprites)
    {
        string descr = "";
        Item itemStat_met;
        foreach (Atributs item in atributs)
        {
            descr += item.stat + " " + item.count + " \n";
        }
        itemStat_met = new Item(type, type.ToString(), descr, sprites[Random.Range(0, sprites.Count)], atributs);
        return itemStat_met;
    }
}
