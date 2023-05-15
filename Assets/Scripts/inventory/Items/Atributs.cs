using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atributs
{
    public enum Stat
    {
        deffens,
        damage,
        hpHeal,
        attakSpeead,
        mpHeal,
        mpRegen,
        hpRegen,
        Healse,
        Mana,
        elusion
    }
    public int count;
    public Stat stat;
    public Atributs(Stat _stat, int _count)
    {
        stat = _stat;
        count = _count;
    }
}
