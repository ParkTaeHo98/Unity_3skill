using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum WeaponType
{
    Sword,
    Bow,
    Staff,
}

[CreateAssetMenu(fileName ="WeaponInfo",menuName = "New WeaponInfo")]
public class WeaponInfo : ScriptableObject
{
    [Header("Type")]
    public string weaponName;
    public Sprite icon;
    public WeaponType weaponType;
    public int weaponAd;
    public int weaponPrice;
    public bool choice;
}
