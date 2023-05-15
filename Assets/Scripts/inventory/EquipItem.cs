using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipItem : MonoBehaviour
{
    private Player player;
    public Item item;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    public void UpdateStatsUP()
    {
        Stats stat = player.stats;
        foreach (var st in item.atributs)
        {
            switch (st.stat)
            {
                case Atributs.Stat.damage:
                    stat.damage += st.count;
                    break;
                case Atributs.Stat.deffens:
                    stat.defense += st.count;
                    break;
                case Atributs.Stat.elusion:
                    stat.elusion += st.count;
                    break;
                case Atributs.Stat.Healse:
                    stat.HP += st.count;
                    break;
                case Atributs.Stat.Mana:
                    stat.MP += st.count;
                    break;
            }
        }
        player.stats = stat;
    }
    public void UpdateStatsDawn()
    {
        Stats stat = player.stats;
        foreach (var st in item.atributs)
        {
            switch (st.stat)
            {
                case Atributs.Stat.damage:
                    stat.damage -= st.count;
                    break;
                case Atributs.Stat.deffens:
                    stat.defense -= st.count;
                    break;
                case Atributs.Stat.elusion:
                    stat.elusion -= st.count;
                    break;
                case Atributs.Stat.Healse:
                    stat.HP -= st.count;
                    break;
                case Atributs.Stat.Mana:
                    stat.MP -= st.count;
                    break;
            }
        }
        player.stats = stat;
    }
}
