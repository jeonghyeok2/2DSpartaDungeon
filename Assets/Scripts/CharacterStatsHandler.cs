using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandler : PlayerController
{
    public PlayerSo playerSo;

    private int minAttack = 20;
    private int minHealth = 100;
    private int minDefense = 20;
    private int minSpeed = 10;

    private void Start()
    {
        StatusEvent += StatusUpdate;
    }

    private void StatusUpdate(PlayerSo playerSo)
    {
        UIManager.instance._attackTxt.text = playerSo._attack.ToString();
        UIManager.instance._healthTxt.text = playerSo._health.ToString();
        UIManager.instance._defenceTxt.text = playerSo._defense.ToString();
        UIManager.instance._speedTxt.text = playerSo._speed.ToString();
    }
    public void ItemEquipStatusUpdate(ItemData itemData, int statusValue)
    {
        if (ItemData.ItemType.Wepon == itemData.itemType)
        {
            playerSo._attack = (playerSo._attack + statusValue < minAttack) ? minAttack : playerSo._attack + statusValue;
        }
        else if (ItemData.ItemType.Defense == itemData.itemType)
        {
            playerSo._defense = (playerSo._defense + statusValue < minDefense) ? minDefense : playerSo._defense + statusValue;
        }
        else if (ItemData.ItemType.Speed == itemData.itemType)
        {
            playerSo._speed = (playerSo._speed + statusValue < minSpeed) ? minSpeed : playerSo._speed + statusValue;
        }
        else if (ItemData.ItemType.Health == itemData.itemType)
        {
            playerSo._health = (playerSo._health + statusValue < minHealth) ? minHealth : playerSo._health + statusValue;
        }
    }

    public string Gold()
    {
        return playerSo._gold.ToString();   
    }
}
