using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IInventory : MonoBehaviour
{
    private float EmptySlot;
    public List<GameObject> AllSlot;
    void Awake()
    {
        EmptySlot = AllSlot.Count;
    }
    public bool AddItem(IItem item)
    {

        // 슬롯에 총 개수.
        int slotCount = AllSlot.Count;

        // 넣기위한 아이템이 슬롯에 존재하는지 검사.
        for (int i = 0; i < slotCount; i++)
        {
            // 그 슬롯의 스크립트를 가져온다.
            ISlot slot = AllSlot[i].GetComponent<ISlot>();

            // 슬롯이 비어있으면 통과.
            if (!slot.isSlots())
                continue;
            else
            {
                slot.AddItem(item);
                return true;

            }
            // 슬롯에 존재하는 아이템의 타입과 넣을려는 아이템의 타입이 같고.
            // 슬롯에 존재하는 아이템의 겹칠수 있는 최대치가 넘지않았을 때. (true일 때)

            // 슬롯에 아이템을 넣는다.
            
            
        }

        // 빈 슬롯에 아이템을 넣기위한 검사.
        for (int i = 0; i < slotCount; i++)
        {
            ISlot slot = AllSlot[i].GetComponent<ISlot>();

            // 슬롯이 비어있지 않으면 통과
            if (slot.isSlots())
                continue;

            slot.AddItem(item);
            return true;
        }

        // 위에 조건에 해당되는 것이 없을 때 아이템을 먹지 못함.
        return false;
    }

    public ISlot NearDisSlot(Vector3 Pos)
    {
        float Min = 10000f;
        int Index = -1;

        int Count = AllSlot.Count;
        for (int i = 0; i < Count; i++)
        {
            Vector2 sPos = AllSlot[i].transform.GetChild(0).position;
            float Dis = Vector2.Distance(sPos, Pos);

            if (Dis < Min)
            {
                Min = Dis;
                Index = i;
            }
        }

        if (Min > 10)
            return null;

        return AllSlot[Index].GetComponent<ISlot>();
    }

    // 아이템 옮기기 및 교환.
    public void Swap(ISlot slot, Vector3 Pos)
    {
        ISlot FirstSlot = NearDisSlot(Pos);

        // 현재 슬롯과 옮기려는 슬롯이 같으면 함수 종료.
        if (slot == FirstSlot || FirstSlot == null)
        {
            slot.UpdateInfo(true, slot.slot.Peek().DefaultImg);
            return;
        }

        // 가까운 슬롯이 비어있으면 옮기기.
        if (!FirstSlot.isSlots())
        {
            Swap(FirstSlot, slot);
        }
        // 교환.
        else
        {
            int Count = slot.slot.Count;
            IItem item = slot.slot.Peek();
            Stack<IItem> temp = new Stack<IItem>();

            {
                for (int i = 0; i < Count; i++)
                    temp.Push(item);

                slot.slot.Clear();
            }

            Swap(slot, FirstSlot);

            {
                Count = temp.Count;
                item = temp.Peek();

                for (int i = 0; i < Count; i++)
                    FirstSlot.slot.Push(item);

                FirstSlot.UpdateInfo(true, temp.Peek().DefaultImg);
            }
        }
    }

    // 1: 비어있는 슬롯, 2: 안 비어있는 슬롯.
    void Swap(ISlot xFirst, ISlot oSecond)
    {
        int Count = oSecond.slot.Count;
        IItem item = oSecond.slot.Peek();

        for (int i = 0; i < Count; i++)
        {
            if (xFirst != null)
                xFirst.slot.Push(item);
        }

        if (xFirst != null)
            xFirst.UpdateInfo(true, oSecond.ItemReturn().DefaultImg);

        oSecond.slot.Clear();
        oSecond.UpdateInfo(false, oSecond.DefaultImg);
    }
}


