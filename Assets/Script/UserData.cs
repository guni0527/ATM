using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class UserData
{
    public string userName;
    public float cashOnHand;
    public float bankBalance;


    public UserData(string userName, float cashOnHand, float bankBalance)
    {
        this.userName = userName;
        this.cashOnHand = cashOnHand;
        this.bankBalance = bankBalance;
    }
    


}
