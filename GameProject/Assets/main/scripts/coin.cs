﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
                gameObject.SetActive(false);
    }
}
