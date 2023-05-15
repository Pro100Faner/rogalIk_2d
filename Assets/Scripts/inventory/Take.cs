using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take : MonoBehaviour
{
    private InventoryPanel inventory;
    private ObjTake curr;
    void Start()
    {
        inventory = GameObject.Find("Canvas").GetComponent<InventoryPanel>();
        curr = GameObject.Find("boolll").GetComponent<ObjTake>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            curr.Aktivate();
            curr.item = gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        curr.Close();
    }
    public void Takeitem(){

        if (inventory.count < 15)
        {
            inventory.AddItem(gameObject);
            Destroy(gameObject);
        }
    }
}
