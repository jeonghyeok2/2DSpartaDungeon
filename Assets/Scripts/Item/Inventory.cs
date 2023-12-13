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
    private GameObject go_SlotsParent;  // Slot���� �θ��� Grid Setting 

    private Slot[] slots;  // ���Ե� �迭

    void Start()
    {
        slots = go_SlotsParent.GetComponentsInChildren<Slot>();
        CreateSlotItem(items); //������ �ʱ�ȭ
    }

    private void Update()
    {
       
    }
    public void CreateSlotItem(List<ItemData> item) //���� ������ �ִ� ������ ���� �� ����
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

    public void AddItemCountOverCheck(ItemData _item) //�������� ������ ���Ž�
    {
        if (items.Count < slots.Length)
        {
            items.Add(_item);
            CreateSlotItem(items);
        }
        else
        {
            //���â
        }
    }
}
