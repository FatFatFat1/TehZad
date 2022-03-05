using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerButton : MonoBehaviour
{
    public GameObject ControllerPanels;
    bool isActive = false;
    public void ControllerPressed()
    {
        ControllerPanels.SetActive(isActive=!isActive);
    }
}
