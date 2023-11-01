using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handle the mode selection
/// <summary>
public class ModeSelectHandler : MonoBehaviour
{
    public GameObject Welcome_Canvas;
    public GameObject Follow_Canvas;
    public GameObject Avoidance_Canvas;
    public GameObject ModelSelect_Cancas;
    public GameObject carObj;

    public void Awake()
    {
        Follow_Canvas.SetActive(false);
        Avoidance_Canvas.SetActive(false);
        carObj.SetActive(false);
    }

    public void OnAvoidance()
    {
        Welcome_Canvas.SetActive(false);
        ModelSelect_Cancas.SetActive(false);
        Follow_Canvas.SetActive(false);
        Avoidance_Canvas.SetActive(true);
    }

    public void OnFollow()
    {
        Welcome_Canvas.SetActive(false);
        ModelSelect_Cancas.SetActive(false);
        Avoidance_Canvas.SetActive(false);
        Follow_Canvas.SetActive(true);
    }

    public void OnQuit()
    {
        Follow_Canvas.SetActive(false);
        ModelSelect_Cancas.SetActive(false);
        Welcome_Canvas.SetActive(true);
    }
}