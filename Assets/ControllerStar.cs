using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControllerStar : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    public static GameObject mydraggablesprite;
    Vector3 starPosition;
    float zDistanceToCamera;
    Vector3 touchOffset;

    public void OnBeginDrag(PointerEventData evenData)
    {
        mydraggablesprite = gameObject;
        starPosition = transform.position;
        zDistanceToCamera = Mathf.Abs(starPosition.z - Camera.main.transform.position.z);
        touchOffset = starPosition - Camera.main.ScreenToWorldPoint
            (new Vector3(Input.mousePosition.x,  Input.mousePosition.y, zDistanceToCamera));
    }

    public void OnDrag(PointerEventData evenData)
    {
        if(Input.touchCount > 1)
            return;
        transform.position = Camera.main.ScreenToWorldPoint
            (new Vector3(Input.mousePosition.x,  Input.mousePosition.y, zDistanceToCamera))+touchOffset;
    }

    public void OnEndDrag(PointerEventData evenData)
    {
        mydraggablesprite = null;
        touchOffset = Vector3.zero;
    }

}
