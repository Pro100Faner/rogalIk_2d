using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemy;

public class Enemy : MonoBehaviour
{
    public EnemyStats stats;
    private void Update()
    {

    }
    public void CheacHP()
    {
        if (stats.hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
