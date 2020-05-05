using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public Camera Left1Camera, Left2Camera, Left3Camera, Right1Camera, Right2Camera, Right3Camera, BookCamera, MainCamera, BossCamera, BeamCamera, OutCamera, WallCamera;
    GameObject CM;
    bool bl;
    // Start is called before the first frame update
    void Start()
    {
        CM = GameObject.Find("CameraManager").GetComponent<CameraManager>().WallArea;
        bl = GameObject.Find("CameraManager").GetComponent<CameraManager>().check1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click_Escape()
    {
        //CM.SetActive(false);
        //bl = false;
        MainCamera.gameObject.SetActive(true);

        Left1Camera.gameObject.SetActive(false);
        Left2Camera.gameObject.SetActive(false);
        Left3Camera.gameObject.SetActive(false);
        Right1Camera.gameObject.SetActive(false);
        Right2Camera.gameObject.SetActive(false);
        Right3Camera.gameObject.SetActive(false);
        BookCamera.gameObject.SetActive(false);
        BossCamera.gameObject.SetActive(false);
        BeamCamera.gameObject.SetActive(false);
        OutCamera.gameObject.SetActive(false);
        WallCamera.gameObject.SetActive(false);
    }
}
