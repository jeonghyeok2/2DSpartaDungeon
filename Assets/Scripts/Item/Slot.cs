using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class Slot : MonoBehaviour
{
    public ItemData item; //������
    public Image itemImage;  // �������� �̹���
    public Button itemSelectBtn;  // ������ ���ù�ư

    private bool isEquip;

    [SerializeField]
    private GameObject text_Equip;

    private void Awake()
    {
        itemSelectBtn.onClick.AddListener(() => itemSelect());
    }
    // �κ��丮�� ���ο� ������ ���� �߰�
    public void AddItem(ItemData _item)
    {
        item = _item;
        if (item != null) 
        {
            itemImage.sprite = item.itemImage;
        }
    }
    public void itemSelect() 
    {
        isEquip = item.isEquip;
        if (!isEquip)
        {
            EquipTxt(true);
            EquipStatus(1);
            item.isEquip = !isEquip;
        }
        else
        {
            EquipTxt(false);
            EquipStatus(-1);
            item.isEquip = !isEquip;
        }
    }
    public void EquipStatus(int plusMinus)
    {
        if (item != null)
        {
            UIManager.instance._characterStatsHandler.ItemEquipStatusUpdate(item, item.statusValue * plusMinus);
        }
    }
    public void EquipTxt(bool isEquip)
    {
        text_Equip.SetActive(isEquip);
    }

    // �ش� ���� �ϳ� ����
    private void ClearSlot()
    {
        item = null;
        itemImage.sprite = null;
        
        text_Equip.SetActive(false);
    }
}
