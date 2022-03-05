using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragController : MonoBehaviour , IDragHandler , IPointerClickHandler
{
    public GameObject Player;
    public Camera Cam;
    private Vector2 _distant;

    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _distant = new Vector2(eventData.position.x , 0);
        _distant = Cam.ScreenToWorldPoint(_distant);
    }
    void Update()
    {
        Player.transform.localPosition = Vector2.Lerp(Player.transform.localPosition, new Vector2(_distant.x , 0), Time.deltaTime);
    }
}
