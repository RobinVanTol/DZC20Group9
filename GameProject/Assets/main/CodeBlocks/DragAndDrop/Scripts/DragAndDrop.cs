using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas cv;

    private RectTransform rectT;
    private CanvasGroup Cg;

    private void Awake()
    {
        rectT = GetComponent<RectTransform>();
        Cg = GetComponent<CanvasGroup>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        Cg.blocksRaycasts = false;
        Cg.alpha = 0.55f;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectT.anchoredPosition += eventData.delta / cv.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        Cg.blocksRaycasts = true;
        Cg.alpha = 1f;
    }
}
