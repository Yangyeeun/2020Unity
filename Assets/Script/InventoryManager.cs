using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    bool item1, item2, item3, item4;
    public GameObject Item;
    // Start is called before the first frame update
    void Start()
    {
        item1 = true;
        item2 = false;
        item3 = false;
        item4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(item1 == true)
        {
            Instantiate(Item, new Vector3(1732, 1013, 10), Quaternion.identity);
            
        }
    }
}
