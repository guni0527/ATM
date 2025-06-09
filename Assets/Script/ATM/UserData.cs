using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class UserData
{
    public string userName;
    public float cashOnHand;
    public float bankBalance;
    public string id;
    public string password;

    public UserData(string userName, float cashOnHand, float bankBalance)//만들때 호출됨
    {
        this.userName = userName;
        this.cashOnHand = cashOnHand;
        this.bankBalance = bankBalance;
        this.id = "";
        this.password = "";
    }
    public UserData(string userName, float cashOnHand, float bankBalance, string id, string password)
    {
        this.userName = userName;
        this.cashOnHand = cashOnHand;
        this.bankBalance = bankBalance;
        this.id = id;
        this.password = password;
    }


}
