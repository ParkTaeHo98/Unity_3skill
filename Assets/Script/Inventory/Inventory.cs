using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ItemSlot
{
    public WeaponInfo WeaponInfos;
}
public class Inventory : MonoBehaviour
{
    public InventorySlot[] InvenSlot;
    public ItemSlot[] slots;

    public static Inventory instance;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        slots = new ItemSlot[InvenSlot.Length];

        for (int i = 0; i < slots.Length; i++)
        {
            slots[i] = new ItemSlot();
            InvenSlot[i].index = i;
            InvenSlot[i].Clear();
        }
    }
    public void AddItem(WeaponInfo Weapon)
    {
        ItemSlot emptySlot = GetEmptySlot();
        emptySlot.WeaponInfos = Weapon;
        UpdateInven();

        return;
    }
    private void UpdateInven()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].WeaponInfos != null)
            {
                InvenSlot[i].Set(slots[i]);
            }
            else
            {
                InvenSlot[i].Clear();
            }
        }
    }
    ItemSlot GetEmptySlot()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].WeaponInfos == null)
                return slots[i];
        }
        return null;
    }
}
