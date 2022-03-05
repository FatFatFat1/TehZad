using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeController : MonoBehaviour, IDragHandler
{
    public GameObject Player;
    public void OnDrag(PointerEventData eventData)
    {
        Player.transform.localPosition = Vector2.Lerp(Player.transform.position, new Vector2(eventData.delta.x, 0), Time.deltaTime);
    }
}
