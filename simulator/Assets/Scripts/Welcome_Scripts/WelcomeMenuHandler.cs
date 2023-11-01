using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

/// <summary>
/// Realize the control of the welcome GUI
/// <summary>
public class WelcomeMenuHandler : MonoBehaviour
{
    public GameObject Welcome_Canvas;
    public GameObject ModeSelectCanvas;
    public GameObject carObj;
    public string Username = null;
    public string Password = null;

    public void Awake()
    {
        Welcome_Canvas.SetActive(true);
        ModeSelectCanvas.SetActive(false);
        carObj.SetActive(false);
    }

    public void OnStartButton()
    {
        if(this.Username!= "" && this.Password!= "")
        {
            Welcome_Canvas.SetActive(false);
            ModeSelectCanvas.SetActive(true);
        }
        else
        {
            //UnityEditor.EditorUtility.DisplayDialog("Error", "Please Input Username and Password!", "OK", "NO");
        }
    }

    public void OnQuitButton()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
    }

    public void SetUsername(string username)
    {
        this.Username = username;
    }

    public void SetPassword(string password)
    {
        this.Password = password;
    }
}
