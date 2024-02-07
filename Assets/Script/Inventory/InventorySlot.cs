using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Button button;
    public Image icon;
    public GameObject chack;
    public GameObject popUp;
    public int index;
    public PlayerInfo playerInfo;

    public bool popUpChack;

    private void Update()
    {
        if (playerInfo.weapons[index] != null)
        {
            icon.sprite = playerInfo.weapons[index].icon;
        }
    }
    public void OnSelect()
    {
        if (chack.activeSelf == false && icon.sprite != null)
        {
            popUp.SetActive(true);
        }
        else if (chack.activeSelf == true && icon.sprite != null)
        {
            popUp.SetActive(true);
        }
    }
    public void OnSelectChack()
    {
        if (chack.activeSelf == false)
        {
            chack.SetActive(true);
            playerInfo.weapons[index].choice = true;
            playerInfo.playerAttack += playerInfo.weapons[index].weaponAd;
        } else if (chack.activeSelf == true)
        {
            chack.SetActive(false);
            playerInfo.weapons[index].choice = false;
            playerInfo.playerAttack -= playerInfo.weapons[index].weaponAd;
        }
        popUp.SetActive(false);
    }
    public void OffSelectChack()
    {
        popUp.SetActive(false);
    }
}
