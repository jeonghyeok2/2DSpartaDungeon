using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandler : PlayerController
{
    public PlayerSo playerSo;

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

    public string Gold()
    {
        return playerSo._gold.ToString();   
    }
}
