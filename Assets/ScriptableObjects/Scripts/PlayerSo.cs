using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DefaultPlayerData", menuName = "Datas/PlayerData", order = 0)]
public class PlayerSo : ScriptableObject
{
    [Header("playerData")]
    public int _health;
    public int _attack;
    public int _speed;
    public int _defense;
    public int _gold;
}
