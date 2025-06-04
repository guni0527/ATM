using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonManager : MonoBehaviour
{

    public GameObject ATM;
    public GameObject DepositUI;
    public void DepositScreen()
    {
        ATM.SetActive(false);
        DepositUI.SetActive(true);
    }

    public void BackToATM()
    {
        ATM.SetActive(true);
        DepositUI.SetActive(false);
    }




}
