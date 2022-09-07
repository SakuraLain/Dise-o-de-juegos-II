using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControllerStar : MonoBehaviour,IBeginDraghandler,IFndDragHandler
{
    public static GameObject mydraggablesprite;
    Vector3 starPsitio;
    float zDistanceToCamera;
    Vector3 touchOffet;

    public void OnBeginDrag(PointerEventData evenData)
    {
        mydraggablesprite - GameObject;
        starPsitio - transfore.position;
        zDistanceToCamera - Mathf.Abs(starPsitio - Camera.main.transform.position.z)
    }

    public void OnDrag(PointerEventData evenData)
    {
        
    }

    public void OnEndDrag(PointerEventData evenData)
    {
        
    }

}
