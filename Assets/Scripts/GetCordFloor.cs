using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GetCordFloor : MonoBehaviour
{
    private Item itemStat;
    private GameObject player;
    public GameObject item;
    private GameObject item1;
    private Tilemap tilemap;
    public GameObject newLvl;
    private List<GameObject> rm;
    public List<Vector3> availablePlaces;
    private List<Vector3> spawning = new List<Vector3>();
    private InitItem init;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rm = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>().rooms;
        availablePlaces = new List<Vector3>();
        Invoke("GetSpFloor", 4.5f);
    }

    void CreateItem()
    {
        
        int colv = availablePlaces.Count;
        
        for (int i = 0; i < Random.Range(colv / 100, colv / 50); i++)
        {
            Vector3 cord = availablePlaces[Random.Range(0, colv)];
            while (spawning.Contains(cord))
            {
                cord = availablePlaces[Random.Range(0, colv)];
            }
            item1 = Instantiate(item, cord, Quaternion.identity, gameObject.transform);
            init = item1.GetComponent<InitItem>();
            itemStat = init.create();
            init.itemStat = itemStat;
            init.createImage(itemStat.itemSprite);
            spawning.Add(cord);
        }
    }

    void GetSpFloor()
    {
        foreach (var room in rm)
        {
            tilemap = room.transform.Find("Grid").transform.Find("Floor").transform.GetComponentInParent<Tilemap>();
            for (int n = tilemap.cellBounds.xMin; n < tilemap.cellBounds.xMax; n++)
            {
                for (int p = tilemap.cellBounds.yMin; p < tilemap.cellBounds.yMax; p++)
                {
                    Vector3Int locatePl = (new Vector3Int(n, p, 0));
                    Vector3 plase = tilemap.CellToWorld(locatePl);
                    if (tilemap.HasTile(locatePl))
                    {
                        plase.x += 0.5f;
                        plase.y += 0.5f;
                        availablePlaces.Add(plase);
                    }
                }
            }
        }
        CreateItem();
        Vector3 pos = availablePlaces[Random.Range(0, availablePlaces.Count)];
        player.transform.position = pos;
        player.GetComponent<PlayerMovement>().movePoint.position = pos;
        Instantiate(newLvl, availablePlaces[Random.Range(0, availablePlaces.Count)], Quaternion.identity);
    }
}
