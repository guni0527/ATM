using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenButtonManager : MonoBehaviour
{
    public GameObject Staus;
    public GameObject UIInventory;
    public GameObject UIStatus;
    public GameObject ReturnBtn;
    public GameObject Inventory;
    public GameObject No1;
    public GameObject No2;
    public GameObject None;
    public void GotoStat()
    {
        Staus.SetActive(true);
        ReturnBtn.SetActive(true);
        UIStatus.SetActive(false);
        UIInventory.SetActive(false);       
    }
    public void GotoInven()
    {
        Inventory.SetActive(true);
        ReturnBtn.SetActive(true);
        UIStatus.SetActive(false);
        UIInventory.SetActive(false);
    }
    public void Return()
    {
        UIInventory.SetActive(true);
        UIStatus.SetActive(true);
        ReturnBtn.SetActive(false);
        Staus.SetActive(false);
        Inventory.SetActive(false);
    }
    public void equip()
    {

    }
    public void Empty()
    {
        
    }
}
