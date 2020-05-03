using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TrashCan : MonoBehaviour
{
    public bool is_can;
    public Image item;
    public Sprite newitem;
    // Start is called before the first frame update
    void Start()
    {
        is_can = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (gameObject.tag == "trash" && is_can == false)
        {
            Debug.Log("Get Battery");
            item = item.GetComponent<Image>();
            item.sprite = newitem;
            //item = Resources.Load<Sprite>("axe");
            is_can = true;
        }
       
    }
}
