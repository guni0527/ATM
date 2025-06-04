using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BankUIManager : MonoBehaviour
{
    [Header("Title")]
    public TMP_Text titleText;
    public TMP_Text subTitleText;

    [Header("User Info")]
    public TMP_Text userNameText;
    public TMP_Text accountBalanceText;

    [Header("ATM Info")]
    public TMP_Text cashText;
    public Button DepositButton;
    public Button WithdrawButton;

    

    // Start is called before the first frame update
    void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        var userdata = GameManager.Instance.userdata;
        userNameText.text = userdata.userName;
        cashText.text = userdata.cashOnHand.ToString("N0");
        accountBalanceText.text = userdata.bankBalance.ToString("N0");

    }

    public void HideWithdrawal()
    {
        
    }


}
