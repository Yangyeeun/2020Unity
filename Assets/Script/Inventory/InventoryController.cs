using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public GameObject inventory;
    public GameObject closebutton;
    public GameObject openbutton;
    private void Start()
    {
        closebutton.SetActive(false);
        inventory.SetActive(false);
    }
    public void OpenInventory()
    {
        inventory.SetActive(true);
        closebutton.SetActive(true);
        openbutton.SetActive(false);
    }
    public void CloseInventory()
    {
        inventory.SetActive(false);
        closebutton.SetActive(false);
        openbutton.SetActive(true);
    }
}
