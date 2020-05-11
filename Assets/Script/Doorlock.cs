using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Doorlock : MonoBehaviour
{
    public GameObject []numberPrefabs = new GameObject[10];//숫자 프리팹들 저장
    public GameObject parent; //Instantiator 위치 제대로
    public int[] password = new int[4];
    int[] currentNumber = new int[4];
    //x, y 좌표값
    float[] coordX = new float[4];
    float[] coordY = new float[3];
    bool isChanging;

    Vector3 tmpPosition;
    Quaternion tmpRotation;

    // Start is called before the first frame update
    void Start()
    {
        int[] password = { 1, 2, 3, 4 }; //기본 비밀번호: 1234
        int[] currentNumber = { 0, 0, 0, 0 }; //보여지는 숫자 디폴트 값: 0000
        isChanging = false;

        /*
         좌표

        y값/x값	-501.26 -156 189 537
        417
        109.88
        -206
        */

        coordX[0] = -501.26f;
        coordX[1] = -156.0f;
        coordX[2] = 189.0f;
        coordX[3] = 537.0f;

        coordY[0] = 417.0f;
        coordY[1] = 109.88f;
        coordY[2] = -206.0f;




    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Upperside, downside 함수는 0 일때 위에 배치할 숫자, 9일때 아래에 배치할 숫자.

    void NumberSetting()
    {
        /*
         F I R S T : coordX[0]
         */

        /*tmpPosition = new Vector3(coordX[0], coordY[0], 0.0f);
        tmpRotation = new Quaternion(0.0f, 0.0f, 0.0f);
        Instantiate(numberPrefabs[UpperSide(currentNumber[0])], tmpPosition, tmpRotation, parent);

        tmpPosition = new Vector3(coordX[0], coordY[1], 0.0f);
        tmpRotation = new Quaternion(0.0f, 0.0f, 0.0f);
        Instantiate(numberPrefabs[currentNumber[0]], tmpPosition, tmpRotation, parent);

        tmpPosition = new Vector3(coordX[0], coordY[2], 0.0f);
        tmpRotation = new Quaternion(0.0f, 0.0f, 0.0f);
        Instantiate(numberPrefabs[DownSide(currentNumber[0])], tmpPosition, tmpRotation, parent);
         */
        



    }

    int UpperSide(int number)
    {
        int result;
        if (number == 0)
        {
            result = 9;
        }
        else
        {
            result = number - 1;
        }
        return result;
    }

    int DownSide(int number)
    {
        int result;
        if (number == 9)
        {
            result = 0;
        }
        else
        {
            result = number + 1;
        }
        return result;
    }
}
