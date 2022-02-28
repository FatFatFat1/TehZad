using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour, IBeginDragHandler ,IDragHandler
{
    public GameObject Player;
    void Update()
    {
        if(Player.transform.position.x > 6)
        {
            Player.transform.position= new Vector2(6, 0);
        }
        if(Player.transform.position.x < -6)
        {
            Player.transform.position = new Vector2(-6 ,0);
        }
    }
#if UNITY_IOS || UNITY_ANDROID
    //Swipe
    public void OnBeginDrag(PointerEventData eventData)
    {
        Player.transform.position = Vector2.Lerp(Player.transform.position , new Vector2(eventData.delta.x , 0) , Time.deltaTime);
    }

    public void OnDrag(PointerEventData eventData)
    {

    }
#endif
}
