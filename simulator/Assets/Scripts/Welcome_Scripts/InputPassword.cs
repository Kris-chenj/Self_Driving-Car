using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Handle Input Username and Password
/// <summary>
public class InputPassword : MonoBehaviour
{
    public GameObject WelcomeHander;

    public void Start()
    {
        transform.GetComponent<InputField>().onEndEdit.AddListener(PasswordInput);
    }

    public void PasswordInput(string password)
    {
        WelcomeHander.GetComponent<WelcomeMenuHandler>().SetPassword(password);
    }
}
