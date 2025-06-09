using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Windows;

public class PopupSignUp : MonoBehaviour
{
    public TMP_InputField inputID;
    public TMP_InputField inputName;
    public TMP_InputField inputPassword;
    public TMP_InputField inputPasswordConform;

    [SerializeField] private TMP_Text texterror;
    public GameObject popupSignup;
    public GameObject errorPanel;

    public void SignUp()
    {
        if(string.IsNullOrWhiteSpace(inputID.text))
        {
            texterror.text = "ID가 비어있어요";
            OpenErrorPanel();
            return;
        }

        if (string.IsNullOrWhiteSpace(inputName.text))
        {
            texterror.text = "이름이 비어있어요";
            OpenErrorPanel();
            return;
        }
        if (string.IsNullOrWhiteSpace(inputPassword.text))
        {
            texterror.text = "Password를 확인해주세요.";
            OpenErrorPanel();
            return;
        }
        if (string.IsNullOrEmpty(inputPasswordConform.text))
        {
            texterror.text = "Password Confirm을 확인해주세요.";
            OpenErrorPanel();
            return;
        }
        if (inputPassword.text != inputPasswordConform.text)
        {
            texterror.text = "Password가 같지 않습니다.";
            OpenErrorPanel();
            return;
        }
        if (GameManager.Instance != null)
        {
            GameManager.Instance.SetUserData(new UserData
                (userName: inputName.text,
                cashOnHand: 100000,
                bankBalance: 50000,
                id: inputID.text,
                password: inputPassword.text));
        }








    }










    public void OpenErrorPanel()
    {
        errorPanel.SetActive(true);
    }

}
