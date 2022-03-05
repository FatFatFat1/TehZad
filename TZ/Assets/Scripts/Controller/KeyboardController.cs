using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localPosition = Vector2.Lerp(transform.localPosition, new Vector2(transform.localPosition.x - 1, 0), Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localPosition = Vector2.Lerp(transform.localPosition, new Vector2(transform.localPosition.x + 1, 0), Time.deltaTime);
        }
    }
}
