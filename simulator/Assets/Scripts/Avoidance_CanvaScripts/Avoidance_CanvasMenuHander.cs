using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handle the Avoidance Menu
/// <summary>
public class Avoidance_CanvasMenuHander : MonoBehaviour
{
    public GameObject Avoidance_Canvas;
    public GameObject ModelSelect_Cancas;
    public GameObject carObj;
    public GameObject carJSControl;
    public CameraFollow cameraFollow;
    public TrainingManager trainingManager;
    public GameObject NetworkSteering;

    public void Awake()
    {
        cameraFollow = GameObject.FindObjectOfType<CameraFollow>();
    }

    public void OnReturnMode()
    {
        Avoidance_Canvas.SetActive(false);
        carObj.SetActive(false);
        ModelSelect_Cancas.SetActive(true);
    }

    public void OnBuildRoad()
    {
        if (trainingManager != null)
        {
            carObj.SetActive(true);
            trainingManager.OnMenuRegenStright();
        }
    }

    public void OnCameraFollow()
    {
        carObj.SetActive(true);
        cameraFollow.ifFollow = !cameraFollow.ifFollow;
    }

    public void ManuallyDrive()
    {
        if (carJSControl != null)
            carJSControl.SetActive(true);
    }

    public void OnNNDrive()
    {
        if (carJSControl != null)
            carJSControl.SetActive(false);

        NetworkSteering.SetActive(true);
    }
}