using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ButtonManager : MonoBehaviour
{

    public GameObject ATM;
    public GameObject DepositUI;
    public GameObject WithdrawalUI;
    public GameObject MinusPopup;
    public TMP_InputField DepositMoney;
    public TMP_InputField WithdrawalMoney;

    public void DepositScreen()
    {
        ATM.SetActive(false);
        DepositUI.SetActive(true);       
    }

    public void BackToATM()
    {
        ATM.SetActive(true);
        DepositUI.SetActive(false);
        WithdrawalUI.SetActive(false);
    }
    public void WithdrawalScreen()
    {
        WithdrawalUI.SetActive(true);
        DepositUI.SetActive(false);
        ATM.SetActive(false);
    }
    public void HidePopupScreen()
    {
        MinusPopup.SetActive(false);
    }


    public void Deposit(int Cash)
    {
        if (GameManager.Instance.userdata.cashOnHand >= Cash && Cash >= 0)
        {
            GameManager.Instance.userdata.cashOnHand -= Cash;
            GameManager.Instance.userdata.bankBalance += Cash;
            BankUIManager.Instance.Refresh();
            GameManager.Instance.Save();
        }
        else
        {
            MinusPopup.SetActive(true);
            Debug.Log("�ܾ� ����");
        }

      
    }
    public void Withdrawal(int Cash)
    {
        if(GameManager.Instance.userdata.bankBalance >= Cash && Cash >= 0)
        {
            GameManager.Instance.userdata.cashOnHand += Cash;
            GameManager.Instance.userdata.bankBalance -= Cash;
            BankUIManager.Instance.Refresh();
            GameManager.Instance.Save();
        }
        else
        {
            MinusPopup.SetActive(true);
            Debug.Log("�ܾ� ����");
        }
    }
    
    public void WithdrawalMoneyBtn()
    {
        string withdrawalMoneyString = WithdrawalMoney.text;
        int withdrawalMoney = int.Parse(withdrawalMoneyString);
        Withdrawal(withdrawalMoney);
        
    }
    
    public void DepositMoneyBtn()
    {
        string depositMoneyString = DepositMoney.text;
        int depositMoney = int.Parse(depositMoneyString);
        Deposit(depositMoney);
    }

    




    //���� �Ա� or ����� �Ҷ����� save�� �Ұ�
    //�����ѵ� �� ������ ������ �ǰ� �ε������� �����޴� ���� ������ֵ��� �Ұ�
    //ui ���� �����ߴ� ������ �ٲ�� ������ �ɰ�
    //

}
