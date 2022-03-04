using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeControll : MonoBehaviour, IDragHandler
{
    public GameObject Player;
#if UNITY_IOS || UNITY_ANDROID
    //Swipe
    public void OnDrag(PointerEventData eventData)
    {
        Player.transform.position = Vector2.Lerp(Player.transform.position, new Vector2(eventData.delta.x, 0), Time.deltaTime);
    }
#endif
}
