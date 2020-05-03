using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class beam_on : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public static Vector2 remote_position;
    Drag sum_on;
    // Start is called before the first frame update
    void Start()
    {
        sum_on = GameObject.Find("Item1").GetComponent<Drag>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        remote_position = this.transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
        Debug.Log(this.transform.position.x);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if(sum_on.is_sum == true)
        {

        }
    }
}
