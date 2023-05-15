using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject go;

    public void itemDrop(){
        Destroy(go);
    }
}

