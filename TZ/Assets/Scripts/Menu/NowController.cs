using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NowController : MonoBehaviour
{
    public Component[] AllController;
    public void DragAvtive()
    {
        foreach (Behaviour i in AllController)
        {
            i.enabled = false;
        }
        GetComponent<DragController>().enabled = true;
    }
    public void SwipeActive()
    {
        foreach (Behaviour i in AllController)
        {
            i.enabled = false;
        }
        GetComponent<SwipeController>().enabled = true;
    }
    public void KeyboardActive()
    {
        foreach (Behaviour i in AllController)
        {
            i.enabled = false;
        }
        GetComponent<KeyboardController>().enabled = true;
    }

}
