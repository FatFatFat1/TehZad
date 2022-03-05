using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour
{
    public GameObject Player;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player.transform.localPosition = Vector2.Lerp(Player.transform.localPosition, new Vector2(Player.transform.localPosition.x - 1, 0), Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player.transform.localPosition = Vector2.Lerp(Player.transform.localPosition, new Vector2(Player.transform.localPosition.x + 1, 0), Time.deltaTime);
        }
    }
}
