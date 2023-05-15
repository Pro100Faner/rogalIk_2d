using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Item
{
    public string itemName;
    public string itemDescription;
    public Sprite itemSprite;
    public List<Atributs> atributs;
    public enum ItemType
    {
        Helm,
        Boots,
        Armor,
        Wepon,
        Ring,
        Amulet,
        QuestItem,
        UsableItem
    }
    public ItemType itemType;
    public Item(ItemType _type, string _name, string _descr, Sprite _sprite, List<Atributs> _atributs)
    {
        itemName = _name;
        itemDescription = _descr;
        itemSprite = _sprite;
        atributs = _atributs;
        itemType = _type;
    }
}
