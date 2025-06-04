using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance; //�̱���


    [SerializeField] private TMP_Text userName;
    [SerializeField] private TMP_Text cashOnHand;
    [SerializeField] private TMP_Text bankBalance;



    //Ŭ���� //�ʵ�
    public UserData userdata = new UserData("guni", 115000f, 85000f);


    void Start()
    {

        userdata = new UserData("guni", 115000f, 85000f);
    }


    void Update()
    {

    }




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
        }    //�����ڵ� �����ؼ� ���ӸŴ��� ���ũ���� ������Ʈ�ؼ�

    }
}
