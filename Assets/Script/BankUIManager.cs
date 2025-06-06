using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BankUIManager : MonoBehaviour
{

    public static BankUIManager Instance; //싱글톤



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



    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }    //기존코드 참조해서 게임매니저 어웨크쪽을 업데이트해서

    }

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
