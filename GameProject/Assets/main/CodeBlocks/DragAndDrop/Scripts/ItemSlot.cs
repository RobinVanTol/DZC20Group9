using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{

    //private RectTransform GoodJob;
    //private RectTransform DTb1;
    //private RectTransform DTb2;
    //private RectTransform DTb3;
    //private RectTransform Db1;
    //private RectTransform Db2;
    //private RectTransform Db3;
    //bool first;
    //bool second;
    //bool third;


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if  (eventData.pointerDrag != null ) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;


            //first = DTb1.GetComponent<RectTransform>().anchoredPosition == Db1.GetComponent<RectTransform>().anchoredPosition;
            //second = DTb2.anchoredPosition == Db2.anchoredPosition;
            //third = DTb3.anchoredPosition == Db3.anchoredPosition;
        }
    }
}
