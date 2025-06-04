using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance; //싱글톤


    [SerializeField] private TMP_Text userName;
    [SerializeField] private TMP_Text cashOnHand;
    [SerializeField] private TMP_Text bankBalance;



    //클래스 //필드
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
        }    //기존코드 참조해서 게임매니저 어웨크쪽을 업데이트해서

    }
}
