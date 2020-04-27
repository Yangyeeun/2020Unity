using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBookshelf : MonoBehaviour
{
    public GameObject bookshelf;
    bool is_click;
    bool is_ing;
    public float a;

    // Start is called before the first frame update
    void Start()
    {
        is_click = false;
        is_ing = false;
        a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_click == true)
        {
            a += 0.0002f;//이동
            bookshelf.transform.Translate(0, 0, a);

            if (a > 0.0475)//특정 거리 넘으면
            {
                is_click = false;//이동을 멈추고
                is_ing = true;
                a = 0f;
            }
        }
    }

    void OnMouseDown()
    {

        if (is_ing == false)
        {
            is_click = true;
            
        }
    }
}
