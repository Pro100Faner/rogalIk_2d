using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using enemy;
public class EnemySpawn : MonoBehaviour
{
    public List<GameObject> normalSprite;
    public List<GameObject> rareSprite;
    public List<GameObject> epicSprite;
    public List<GameObject> RelictSprite;
    private GameObject enemyPrefab;
    private List<Vector3> spawnPlase;
    private enemy.EnemyStats stat;
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(4.5f);
        spawnPlase = gameObject.GetComponent<GetCordFloor>().availablePlaces;
        int colv_plase = spawnPlase.Count;
        for (int i = 0; i < Random.Range(colv_plase / 100, colv_plase / 40); i++)
        {
            GenType(Random.Range(0, 4));
            GameObject create = Instantiate(enemyPrefab, spawnPlase[Random.Range(0, colv_plase)], Quaternion.identity);
            create.GetComponent<Enemy>().stats = stat;
        }
    }
    void GenType(int type)
    {
        switch (type)
        {
            case 0:
                cheange(normalSprite, EnemyStats.EnemyType.Normal);
                break;
            case 1:
                cheange(rareSprite, EnemyStats.EnemyType.Rare);
                break;
            case 2:
                cheange(epicSprite, EnemyStats.EnemyType.Epic);
                break;
            case 3:
                cheange(RelictSprite, EnemyStats.EnemyType.Relict);
                break;
        }
    }
    void cheange(List<GameObject> prefab, EnemyStats.EnemyType type)
    {
        enemyPrefab = prefab[Random.Range(0, prefab.Count)];
        stat = new EnemyStats(type);
    }
}
