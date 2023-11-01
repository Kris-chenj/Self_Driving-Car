using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Handle Input Username and Password
/// <summary>
public class InputUserName : MonoBehaviour
{
    public GameObject WelcomeHander;

    public void Start()
    {
        transform.GetComponent<InputField>().onEndEdit.AddListener(UserneameInput);
    }

    public void UserneameInput(string username)
    {
        WelcomeHander.GetComponent<WelcomeMenuHandler>().SetUsername(username);
    }
}
