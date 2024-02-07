using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static LobbyBuyController;

public class LobbyShopController : MonoBehaviour
{
    private WeaponInfo weaponInfo;
    private PlayerInfo playerInfo;

    [SerializeField] private GameObject ShopPopUp;
    [SerializeField] private List<WeaponInfo> weapons;
    [SerializeField] private TextMeshProUGUI ShopPopUpText;

    public static LobbyShopController instance; 
    private void Awake()
    {
        instance = this;
    }
    public void OnShopPopUp(Check check)
    {
        ShopPopUp.SetActive(true);
        if (check == Check.lack)
        {
            ShopPopUpText.text = " �ݾ��� �����մϴ�.";
        } else if (check == Check.BuyIt)
        {
            ShopPopUpText.text = "���ſϷ�!";
        }
    }
    public void OffShopPopUp()
    {
        ShopPopUp.SetActive(false);
    }
}
