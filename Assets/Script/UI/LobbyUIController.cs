using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LobbyUIController : MonoBehaviour
{
    [Header("MENU")]
    [SerializeField] private GameObject _menu;

    [Header("POPUP")]
    [SerializeField] private GameObject _statusPopup;
    [SerializeField] private GameObject _invenPopup;
    [SerializeField] private GameObject _shopPopup;
    [SerializeField] private GameObject _atmPopup;

    [Header("Asset")]
    [SerializeField] private PlayerInfo _playerInfo;

    [Header("InfoText")]
    [SerializeField] private TextMeshProUGUI _playerNameText;
    [SerializeField] private TextMeshProUGUI _playerGoldText;
    [SerializeField] private TextMeshProUGUI _playerInfoText;

    [Header("StatusText")]
    [SerializeField] private TextMeshProUGUI _statusAttack;
    [SerializeField] private TextMeshProUGUI _statusDefense;
    [SerializeField] private TextMeshProUGUI _statusHealth;
    [SerializeField] private TextMeshProUGUI _statusCritical;

    private void Update()
    {
        _playerNameText.text = _playerInfo.playerName.ToString();
        _playerGoldText.text = _playerInfo.playerGold.ToString();
        _playerInfoText.text = _playerInfo.playerInfo.ToString();
    }
    public void OnStatusPopUp()
    {
        _menu.SetActive(false);
        _statusPopup.SetActive(true);
        _statusAttack.text = _playerInfo.playerAttack.ToString();
        _statusDefense.text = _playerInfo.playerDefense.ToString();
        _statusHealth.text = _playerInfo.playerHealth.ToString();
        _statusCritical.text = _playerInfo.playerCritical.ToString();
    }
    public void OffStatusPopUp()
    {
        _menu.SetActive(true);
        _statusPopup.SetActive(false);
    }
    public void OnInvenPopUp()
    {
        _menu.SetActive(false);
        _invenPopup.SetActive(true);
    }
    public void OffInvenPopUp()
    {
        _menu.SetActive(true);
        _invenPopup.SetActive(false);
    }
    public void OnShopPopUp()
    {
        _menu.SetActive(false);
        _shopPopup.SetActive(true);
    }
    public void OffShopPopUp()
    {
        _menu.SetActive(true);
        _shopPopup.SetActive(false);
    }
    public void OnATMPopUp()
    {
        _menu.SetActive(false);
        _atmPopup.SetActive(true);
    }
    public void OffATMPopUp()
    {
        _menu.SetActive(true);
        _atmPopup.SetActive(false);
    }
}
