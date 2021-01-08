using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratsPop : MonoBehaviour
{
    private GameObject text;


    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("GoodJob").GetComponent<RectTransform>().gameObject;
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        bool first = GameObject.Find("DragToBlock1").GetComponent<RectTransform>().anchoredPosition == GameObject.Find("GoodFor").GetComponent<RectTransform>().anchoredPosition;
        bool second = GameObject.Find("DragToBlock2").GetComponent<RectTransform>().anchoredPosition == GameObject.Find("GoodIf").GetComponent<RectTransform>().anchoredPosition;
        bool third = GameObject.Find("DragToBlock3").GetComponent<RectTransform>().anchoredPosition == GameObject.Find("GoodLast").GetComponent<RectTransform>().anchoredPosition;
        if (first && second && third)
        {
            text.SetActive(true);
            Debug.Log("Completed");
        }

    }
}
