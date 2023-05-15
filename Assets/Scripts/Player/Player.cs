using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Stats stats;
    public static bool death;
    public int curHP;
    public int curMP;
    public float curEXP;

    void Start()
    {
        stats = new Stats(1, 1000);
        death = false;
        curHP = stats.HP;
        curMP = stats.MP;
        Time.timeScale = 1;
    }

    void Update()
    {   if (Input.GetKeyDown(KeyCode.K))
        {
            curEXP += 100;
        }
        StatCheak();
    }
    private void StatCheak()
    {
        if (curHP > stats.HP)
        {
            curHP = stats.HP;
        }
        else if (curHP <= 0)
        {
            curHP = 0;
            death = true;
            Time.timeScale = 0;
        }
        if (curMP > stats.MP)
        {
            curMP = stats.MP;
        }
        else if (curMP < 0)
        {
            curMP = 0;
        }
        if (curEXP >= stats.EXP)
        {
            stats.LvlUp();
            curEXP = 0;
            curHP = stats.HP;
        }
    }
}
