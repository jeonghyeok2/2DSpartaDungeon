using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class Inventory : MonoBehaviour
{
    public List<ItemData> items;

    [SerializeField]
    private GameObject go_SlotsParent;  // Slot들의 부모인 Grid Setting 

    private Slot[] slots;  // 슬롯들 배열

    void Start()
    {
        slots = go_SlotsParent.GetComponentsInChildren<Slot>();
        CreateSlotItem(items); //아이템 초기화
    }

    private void Update()
    {
       
    }
    public void CreateSlotItem(List<ItemData> item) //현재 가지고 있는 아이템 생성 및 공백
    {
        int i = 0;

        for (; i < items.Count && i < slots.Length; i++)
        {
            slots[i].AddItem(item[i]);
            slots[i].EquipTxt(item[i].isEquip);
        }
        for (; i < slots.Length; i++)
        {
            slots[i].AddItem(null);
        }
    }

    public void AddItemCountOverCheck(ItemData _item) //상점에서 아이템 구매시
    {
        if (items.Count < slots.Length)
        {
            items.Add(_item);
            CreateSlotItem(items);
        }
        else
        {
            //경고창
        }
    }
}
