using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public InventorySlot[] InvenSlot;
    public static Inventory instance;

    void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        for (int i = 0; i < InvenSlot.Length; i++)
        {
            InvenSlot[i].index = i;
        }
    }
}
