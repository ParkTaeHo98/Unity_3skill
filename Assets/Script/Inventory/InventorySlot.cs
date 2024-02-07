using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Button button;
    public Image icon;
    public int index;
    private ItemSlot curslot;

    public void Set(ItemSlot slot)
    {
        curslot = slot;
        icon.gameObject.SetActive(true);
        icon.sprite = slot.WeaponInfos.icon;
    }
    public void Clear()
    {
        curslot = null;
        icon.gameObject.SetActive(false);
    }
}
