using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IItem : MonoBehaviour
{
    public int MaxCount;
    private IInventory Iv;
    public Sprite DefaultImg;
    void Awake()
    {
        // 태그명이 "Inventory"인 객체의 GameObject를 반환한다.
        // 반환된 객체가 가지고 있는 스크립트를 GetComponent를 통해 가져온다.
        Iv = GameObject.FindGameObjectWithTag("Inventory").GetComponent<IInventory>();

    }

    void AddItem()
    {
        // 아이템 획득에 실패할 경우.
        if (!Iv.AddItem(this))
            Debug.Log("아이템이 가득 찼습니다.");
        else // 아이템 획득에 성공할 경우.
            gameObject.SetActive(false); // 아이템을 비활성화 시켜준다.
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
