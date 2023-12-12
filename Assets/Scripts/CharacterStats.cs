using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Attack,
    Defense,
    Health,
}
[Serializable]
public class CharacterStats
{
    public ItemType itemType;
    public int _plusStatus;
}
