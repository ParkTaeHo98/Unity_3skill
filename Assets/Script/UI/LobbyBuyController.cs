using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class LobbyBuyController : MonoBehaviour
{
    public enum Check
    {
        lack,
        BuyIt,
    }
    [SerializeField] private WeaponInfo weaponInfo;
    [SerializeField] private PlayerInfo playerInfo;

    public Image image;
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI PriceText;

    private void Awake()
    {
        image = image.GetComponent<Image>();
        NameText = NameText.GetComponent<TextMeshProUGUI>();
        PriceText = PriceText.GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        image.sprite = weaponInfo.icon;
        NameText.text = weaponInfo.weaponName;
        PriceText.text = weaponInfo.weaponPrice.ToString() + " Gold";
    }
    public void BuyItem()
    {
        if (playerInfo.playerGold >= weaponInfo.weaponPrice)
        {
            Check check = Check.BuyIt;
            LobbyShopController.instance.OnShopPopUp(check);
            playerInfo.playerGold -= weaponInfo.weaponPrice;
            Inventory.instance.AddItem(weaponInfo);
        }
        else
        {
            Check check = Check.lack;
            LobbyShopController.instance.OnShopPopUp(check);
        }
    }
}
