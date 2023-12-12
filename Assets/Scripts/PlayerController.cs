using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public event Action<PlayerSo> StatusEvent;

    public void CallStatusEvent(PlayerSo playerSo)
    {
        StatusEvent?.Invoke(playerSo);
    }
}
