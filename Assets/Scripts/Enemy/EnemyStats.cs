using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace enemy
{
    public class EnemyStats
    {
        public enum EnemyType
        {
            Normal,
            Rare,
            Epic,
            Relict
        }
        public EnemyType enemyType;
        public int hp;
        public int defense;
        public int damage;

        public EnemyStats(EnemyType enemyType)
        {
            this.enemyType = enemyType;
            switch (enemyType)
            {
                case (EnemyType.Normal):
                    Bild(Random.Range(10, 20), Random.Range(0, 5), Random.Range(40, 60));
                    break;
                case (EnemyType.Rare):
                    Bild(Random.Range(20, 30), Random.Range(5, 10), Random.Range(60, 80));
                    break;
                case (EnemyType.Epic):
                    Bild(Random.Range(30, 40), Random.Range(10, 15), Random.Range(80, 100));
                    break;
                case (EnemyType.Relict):
                    Bild(Random.Range(40, 50), Random.Range(20, 25), Random.Range(100, 120));
                    break;

            }
        }
        private void Bild(int damage, int def, int hp)
        {
            this.hp = hp;
            this.defense = def;
            this.damage = damage;
        }

    }
}
