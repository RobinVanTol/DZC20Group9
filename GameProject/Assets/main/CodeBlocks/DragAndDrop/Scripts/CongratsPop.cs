using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratsPop : MonoBehaviour
{
    public GameObject Gtext;
    public GameObject Btext;
    public RectTransform D1;
    public RectTransform D2;
    public RectTransform D3;
    public RectTransform C1;
    public RectTransform C2;
    public RectTransform C3;
    public RectTransform B1;
    public RectTransform B2;
    public RectTransform B3;
    public RectTransform BB1;
    public RectTransform BB2;
    public RectTransform BB3;


    // Start is called before the first frame update
    void Start()
    {
        //text = GameObject.Find("GoodJob").GetComponent<RectTransform>().gameObject;
        Gtext.SetActive(false);
        Btext.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 D1pos = D1.anchoredPosition;
        Vector2 D2pos = D2.anchoredPosition;
        Vector2 D3pos = D3.anchoredPosition;
        Vector2 C1pos = C1.anchoredPosition;
        Vector2 C2pos = C2.anchoredPosition;
        Vector2 C3pos = C3.anchoredPosition;
        Vector2 B1pos = B1.anchoredPosition;
        Vector2 B2pos = B2.anchoredPosition;
        Vector2 B3pos = B3.anchoredPosition;
        Vector2 BB1pos = BB1.anchoredPosition;
        Vector2 BB2pos = BB2.anchoredPosition;
        Vector2 BB3pos = BB3.anchoredPosition;

        bool first = D1pos == C1pos;
        bool second = D2pos == C2pos;
        bool third = D3pos == C3pos;

        bool firstc = D1pos == C1pos || D1pos == C2pos || D1pos == C3pos || D1pos == B1pos || D1pos == B2pos || D1pos == B3pos || D1pos == BB1pos || D1pos == BB2pos || D1pos == BB3pos;
        bool secondc = D2pos == C1pos || D2pos == C2pos || D2pos == C3pos || D2pos == B1pos || D2pos == B2pos || D2pos == B3pos || D2pos == BB1pos || D2pos == BB2pos || D2pos == BB3pos;
        bool thirdc = D3pos == C1pos || D3pos == C2pos || D3pos == C3pos || D3pos == B1pos || D3pos == B2pos || D3pos == B3pos || D3pos == BB1pos || D3pos == BB2pos || D3pos == BB3pos;


        // While all 3 blocks have a corresponding piece of code (wrong or not)
        if (firstc && secondc && thirdc) {

            if (first && second && third)
            {
                Btext.SetActive(false);
                Gtext.SetActive(true);
                //Debug.Log("Completed");
            }
            else Btext.SetActive(true);
        }
        else
        {
            Gtext.SetActive(false);
            Btext.SetActive(false);
        }


    }
}
