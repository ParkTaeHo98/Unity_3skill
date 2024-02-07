using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LobbyATMController : MonoBehaviour
{
    public ATMInfo _ATMInfo;
    public PlayerInfo _PlayerInfo;
    public TextMeshProUGUI _gold;

    public TMP_InputField _inputWithdraw;
    public TMP_InputField _inputDeposit;

    public void Update()
    {
        _gold.text = "ÀºÇà ÀÜ°í : " + _ATMInfo.bank.ToString();
    }
    public void Withdraw()
    {
        if (_ATMInfo.bank >= int.Parse(_inputWithdraw.text))
        {
            _ATMInfo.bank -= int.Parse(_inputWithdraw.text);
            _PlayerInfo.playerGold += int.Parse(_inputWithdraw.text);
        }
    }
    public void Deposit()
    {
        if (_PlayerInfo.playerGold >= int.Parse(_inputDeposit.text))
        {
            _ATMInfo.bank += int.Parse(_inputDeposit.text);
            _PlayerInfo.playerGold -= int.Parse(_inputDeposit.text);
        }
    }
}
