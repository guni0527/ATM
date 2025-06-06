using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance; //싱글톤

    private float autoSaveInterval = 30f; //30마다 저장
    private float timer = 0f;

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
    {               //프레임당 1초
        timer += Time.deltaTime;//현제시간
        if (timer >= autoSaveInterval)
        {
            timer = 0f;
            Save();
        }
    }

    public void Save()
    {
        string json = JsonUtility.ToJson(userdata);
        string path = Application.persistentDataPath + "/Data/" + "/userdata.json";
        File.WriteAllText(path, json); //경로의 json 파일을 저장한다.
        Debug.Log("데이터 저장됨: " + path);
    }

    public void LoadUserData()
    {
       
        string path = Application.persistentDataPath + "/Data/" + "/userdata.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            userdata = JsonUtility.FromJson<UserData>(json);
            Debug.Log("데이터 불러옴" + json);
        }
        else
        {
            Debug.Log("저장된 파일이 없습니다. 기본값 사용");
            GameManager.Instance.userdata = new UserData("guni", 115000f, 85000f);
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            GameManager.Instance.LoadUserData();
        }
        else
        {
            Destroy(gameObject);
            return;
        }    //기존코드 참조해서 게임매니저 어웨크쪽을 업데이트해서

    }
}
