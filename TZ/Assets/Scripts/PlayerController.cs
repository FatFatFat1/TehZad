using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;
    void Update()
    {
        if (Player.transform.position.x > 6)
        {
            Player.transform.position = new Vector2(6, 0);
        }
        if (Player.transform.position.x < -6)
        {
            Player.transform.position = new Vector2(-6, 0);
        }
    }
}

