using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]
public class ItemData : ScriptableObject
{
    public enum ItemType  // 아이템 유형
    {
        Wepon,
        Defense,
        Speed,
        Health,
    }

    public string itemName; // 아이템의 이름
    public ItemType itemType; // 아이템 유형
    public Sprite itemImage; // 아이템의 이미지(인벤 토리 안에서 띄울)
    public int statusValue; // 아이템 플러스 상태
    public bool isEquip;
}

