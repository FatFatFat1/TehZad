using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 2f;
    public GameObject Distant;
    void Update()
    {
        if(Distant.transform.position.x > 6)
        {
            Distant.transform.position = new Vector2(6, Distant.transform.position.y);
        }
        if (Distant.transform.position.x < -6)
        {
            Distant.transform.position = new Vector2(-6, Distant.transform.position.y);
        }
        // Drag
        if (Input.GetKeyDown(KeyCode.A))
        {
            Distant.transform.position = new Vector2(Distant.transform.position.x - 1 , Distant.transform.position.y);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Distant.transform.position = new Vector2(Distant.transform.position.x + 1, Distant.transform.position.y);
        }
        transform.position = Vector2.Lerp(transform.position, Distant.transform.position, Time.deltaTime * _speed);
    }
}
