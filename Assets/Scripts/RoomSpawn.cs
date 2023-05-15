using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawn : MonoBehaviour
{
    public int openingDirection;
    // 1 - bottom
    // 2 - top
    // 3 - left
    //4 - right
    private RoomTemplates templates;
    private Transform dict;
    private int rand;
    private bool spawning = false;

    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        dict = GameObject.FindGameObjectWithTag("RoomsDict").transform;
        Invoke("Spawn", 0.1f);
    }

    void Spawn()
    {
        if (spawning == false)
        {
            if (openingDirection == 1)
            {
                rand = Random.Range(0, templates.bottomRooms.Length);
                Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation, dict);
            }
            else if (openingDirection == 2)
            {
                rand = Random.Range(0, templates.topRooms.Length);
                Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation, dict);
            }
            else if (openingDirection == 3)
            {
                rand = Random.Range(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation, dict);
            }
            else if (openingDirection == 4)
            {
                rand = Random.Range(0, templates.rightRooms.Length);
                Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation, dict);
            }
            spawning = true;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
		if(other.CompareTag("SpawnPoint")){
			if(other.GetComponent<RoomSpawn>().spawning == false && spawning == false){
				Instantiate(templates.closeRoom, transform.position, Quaternion.identity);
				Destroy(gameObject);
			} 
			spawning = true;
		}
	
    }
}
