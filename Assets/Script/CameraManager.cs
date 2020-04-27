using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraManager : MonoBehaviour
{
    public Camera Left1Camera, Left2Camera, Left3Camera, Right1Camera, Right2Camera, Right3Camera, BookCamera, MainCamera, BossCamera;
    // Start is called before the first frame update
    void Start()
    {
        Left1Camera.gameObject.SetActive(false);
        Left2Camera.gameObject.SetActive(false);
        Left3Camera.gameObject.SetActive(false);
        Right1Camera.gameObject.SetActive(false);
        Right2Camera.gameObject.SetActive(false);
        Right3Camera.gameObject.SetActive(false);
        BookCamera.gameObject.SetActive(false);
        BossCamera.gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainCamera.gameObject.SetActive(true);

            Left1Camera.gameObject.SetActive(false);
            Left2Camera.gameObject.SetActive(false);
            Left3Camera.gameObject.SetActive(false);
            Right1Camera.gameObject.SetActive(false);
            Right2Camera.gameObject.SetActive(false);
            Right3Camera.gameObject.SetActive(false);
            BookCamera.gameObject.SetActive(false);
            BossCamera.gameObject.SetActive(false);
            
        }
    }
    void OnMouseDown()
    {
        if(gameObject.tag == "Left-1")
        {
            Left1Camera.gameObject.SetActive(true);

            Left2Camera.gameObject.SetActive(false);
            Left3Camera.gameObject.SetActive(false);
            Right1Camera.gameObject.SetActive(false);
            Right2Camera.gameObject.SetActive(false);
            Right3Camera.gameObject.SetActive(false);
            BookCamera.gameObject.SetActive(false);
            BossCamera.gameObject.SetActive(false);
            MainCamera.gameObject.SetActive(false);
        }

        if (gameObject.tag == "Left-2")
        {
            Left2Camera.gameObject.SetActive(true);

            Left1Camera.gameObject.SetActive(false);
            Left3Camera.gameObject.SetActive(false);
            Right1Camera.gameObject.SetActive(false);
            Right2Camera.gameObject.SetActive(false);
            Right3Camera.gameObject.SetActive(false);
            BookCamera.gameObject.SetActive(false);
            BossCamera.gameObject.SetActive(false);
            MainCamera.gameObject.SetActive(false);
        }

        if (gameObject.tag == "Left-3")
        {
            Left3Camera.gameObject.SetActive(true);

            Left2Camera.gameObject.SetActive(false);
            Left1Camera.gameObject.SetActive(false);
            Right1Camera.gameObject.SetActive(false);
            Right2Camera.gameObject.SetActive(false);
            Right3Camera.gameObject.SetActive(false);
            BookCamera.gameObject.SetActive(false);
            BossCamera.gameObject.SetActive(false);
            MainCamera.gameObject.SetActive(false);
        }

        if (gameObject.tag == "Right-1")
        {
            Right1Camera.gameObject.SetActive(true);

            Left2Camera.gameObject.SetActive(false);
            Left3Camera.gameObject.SetActive(false);
            Left1Camera.gameObject.SetActive(false);
            Right2Camera.gameObject.SetActive(false);
            Right3Camera.gameObject.SetActive(false);
            BookCamera.gameObject.SetActive(false);
            BossCamera.gameObject.SetActive(false);
            MainCamera.gameObject.SetActive(false);
        }

        if (gameObject.tag == "Right-2")
        {
            Right2Camera.gameObject.SetActive(true);

            Left2Camera.gameObject.SetActive(false);
            Left3Camera.gameObject.SetActive(false);
            Left1Camera.gameObject.SetActive(false);
            Right1Camera.gameObject.SetActive(false);
            Right3Camera.gameObject.SetActive(false);
            BookCamera.gameObject.SetActive(false);
            BossCamera.gameObject.SetActive(false);
            MainCamera.gameObject.SetActive(false);
        }

        if (gameObject.tag == "Right-3")
        {
            Right3Camera.gameObject.SetActive(true);

            Left2Camera.gameObject.SetActive(false);
            Left3Camera.gameObject.SetActive(false);
            Left1Camera.gameObject.SetActive(false);
            Right2Camera.gameObject.SetActive(false);
            Right1Camera.gameObject.SetActive(false);
            BookCamera.gameObject.SetActive(false);
            BossCamera.gameObject.SetActive(false);
            MainCamera.gameObject.SetActive(false);
        }

        if (gameObject.tag == "Boss")
        {
            BossCamera.gameObject.SetActive(true);

            Left2Camera.gameObject.SetActive(false);
            Left3Camera.gameObject.SetActive(false);
            Left1Camera.gameObject.SetActive(false);
            Right2Camera.gameObject.SetActive(false);
            Right3Camera.gameObject.SetActive(false);
            BookCamera.gameObject.SetActive(false);
            Right1Camera.gameObject.SetActive(false);
            MainCamera.gameObject.SetActive(false);
        }

        if (gameObject.tag == "Book")
        {
            BookCamera.gameObject.SetActive(true);

            Left2Camera.gameObject.SetActive(false);
            Left3Camera.gameObject.SetActive(false);
            Left1Camera.gameObject.SetActive(false);
            Right2Camera.gameObject.SetActive(false);
            Right3Camera.gameObject.SetActive(false);
            Right1Camera.gameObject.SetActive(false);
            BossCamera.gameObject.SetActive(false);
            MainCamera.gameObject.SetActive(false);
        }
    }
}
