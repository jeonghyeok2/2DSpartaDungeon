using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class Slot : MonoBehaviour
{
    public ItemData item; //아이템
    public Image itemImage;  // 아이템의 이미지
    public Button itemSelectBtn;  // 아이템 선택버튼

    private bool isEquip;

    [SerializeField]
    private GameObject text_Equip;

    private void Awake()
    {
        itemSelectBtn.onClick.AddListener(() => itemSelect());
    }
    // 인벤토리에 새로운 아이템 슬롯 추가
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

    // 해당 슬롯 하나 삭제
    private void ClearSlot()
    {
        item = null;
        itemImage.sprite = null;
        
        text_Equip.SetActive(false);
    }
}
