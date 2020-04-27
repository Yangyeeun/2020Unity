using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour
{
    public GameObject OpenButton;
    public GameObject CloseButton;
    public GameObject inven;
    // Start is called before the first frame update
    void Start()
    {
        OpenButton.SetActive(true);
        CloseButton.SetActive(false);
        inven.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click_OpenButton()
    {
        OpenButton.SetActive(false);
        CloseButton.SetActive(true);
        inven.SetActive(true);
    }

    public void Click_CloseButton()
    {
        OpenButton.SetActive(true);
        CloseButton.SetActive(false);
        inven.SetActive(false);
    }
}
