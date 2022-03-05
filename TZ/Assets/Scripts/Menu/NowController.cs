using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NowController : MonoBehaviour
{
    public void DragAvtive()
    {
        gameObject.GetComponent<DragController>().enabled = true;
        gameObject.GetComponent<SwipeController>().enabled = false;
        gameObject.GetComponent<KeyboardController>().enabled = false;
    }
    public void SwipeActive()
    {
        gameObject.GetComponent<SwipeController>().enabled = true;
        gameObject.GetComponent<DragController>().enabled = false;
        gameObject.GetComponent<KeyboardController>().enabled = false;
    }
    public void KeyboardActive()
    {
        gameObject.GetComponent<KeyboardController>().enabled = true;
        gameObject.GetComponent<SwipeController>().enabled = false;
        gameObject.GetComponent<DragController>().enabled = false;
    }
}
