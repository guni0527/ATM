using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance; //�̱���

    private float autoSaveInterval = 30f; //30���� ����
    private float timer = 0f;

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
    {               //�����Ӵ� 1��
        timer += Time.deltaTime;//�����ð�
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
        File.WriteAllText(path, json); //����� json ������ �����Ѵ�.
        Debug.Log("������ �����: " + path);
    }

    public void LoadUserData()
    {
       
        string path = Application.persistentDataPath + "/Data/" + "/userdata.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            userdata = JsonUtility.FromJson<UserData>(json);
            Debug.Log("������ �ҷ���" + json);
        }
        else
        {
            Debug.Log("����� ������ �����ϴ�. �⺻�� ���");
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
        }    //�����ڵ� �����ؼ� ���ӸŴ��� ���ũ���� ������Ʈ�ؼ�

    }
}
