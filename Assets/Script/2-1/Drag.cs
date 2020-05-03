using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public static Vector2 defaultposition;
    bool is_remotecontrol;
    public Image item;
    //Sprite battery;
    public Image remotecontrol;
    public Sprite remote;
    public bool is_sum;
    public GameObject Light;
    //public bool is_battery;
    TrashCan bat;
    void Start()
    {
        is_remotecontrol = true;
        bat = GameObject.Find("Trash").GetComponent<TrashCan>();
        is_sum = false;
        Light.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        defaultposition = this.transform.position;

        
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
        
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (is_remotecontrol == true &&  bat.is_can == true && is_sum ==false)//리모컨이 있고 건전지를 얻은 상태라면
        {
            if (this.transform.position.x > 1870 && this.transform.position.x < 2010)
            {
                if (this.transform.position.y > 940 && this.transform.position.y < 1080)//해당 좌표(리모컨이 있는 좌표)에 건전지의 좌표를 드래그 하면
                {
                    Debug.Log(this.transform.position);
                    item = item.GetComponent<Image>();
                    item.sprite = remote;//건전지의 이미지가 합체된 리모컨으로
                    Destroy(remotecontrol);//기존 좌표에 있던 리모컨 이미지 삭제
                    is_sum = true;//리모컨을 합체시킴. -> 빔프로젝터 빔 키는 데에 사용.
                    this.transform.position = new Vector2(1940, 1500);
                }
                else
                {
                    this.transform.position = defaultposition;
                }
            }
            else
            {
                this.transform.position = defaultposition;
            }
        }
        if(is_sum == true)
        {
            if (this.transform.position.x > 890 && this.transform.position.x < 1300)
            {
                Debug.Log("GoodX");
                if (this.transform.position.y > 470 && this.transform.position.y < 700)//해당 좌표(리모컨이 있는 좌표)에 건전지의 좌표를 드래그 하면
                {
                    Debug.Log("GoodXY");
                    Destroy(item);
                    Light.SetActive(true);
                    //this.transform.position = new Vector2(1940, 1010);
                }
                else
                {
                    this.transform.position = defaultposition;
                }
            }
            else
            {
                this.transform.position = defaultposition;
            }
        }
        
    }
}
