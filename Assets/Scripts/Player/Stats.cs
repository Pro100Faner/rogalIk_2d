using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    public int lvl = 1;
    public enum PlayerType
    {
        Engineer,
        Mage,
        Rogue,
        Warrior,
        Paladin,
        Template,

    }
    public PlayerType typeHero;
    public int HP = 100;
    public int MP = 100;
    public float EXP = 1000;
    public int defense = 1;
    public int damage = 10;
    public int elusion = 0;
    public Stats(PlayerType type)
    {
        this.typeHero = type;
    }

    public Stats(int lvl, float EXP)
    {
        this.lvl = lvl;
        this.EXP = EXP;

    }
    public void LvlUp()
    {
        this.lvl += 1;
        this.EXP += Mathf.Floor(this.EXP / 2.5f);
        this.HPnewMPnew();
    }
    public void HPnewMPnew()
    {
        if (typeHero == PlayerType.Engineer)
        {
            this.defense += 2;
            this.damage += 2;
            this.HP += 40;
            this.MP += 10;
        }
        else if (typeHero == PlayerType.Mage){
            this.HP += 20;
            this.MP += 30;
        }
        else if (typeHero == PlayerType.Paladin){
            this.HP += 60;
            this.MP += 15;
        }
        else if (typeHero == PlayerType.Rogue){
            this.damage += 5;
            this.HP += 20;
            this.MP += 5;
        }
        else if (typeHero == PlayerType.Template){
            this.HP += 25;
            this.MP += 25;
        }
        else if (typeHero == PlayerType.Warrior){
            this.defense += 5;
            this.HP += 80;
            this.MP += 5;
        }
    }
}
