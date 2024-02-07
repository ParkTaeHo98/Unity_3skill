using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerInfo",menuName = "New PlayeInfo")]
public class PlayerInfo : ScriptableObject
{
    [Header("Info")]
    public string playerName;
    public int playerLevel;
    public string playerInfo;
    public int playerGold;

    [Header("Status")]
    public int playerAttack;
    public int playerDefense;
    public int playerHealth;
    public int playerCritical;

    [Header("Inventory")]
    public WeaponInfo[] weapons;
}
