﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class completion : MonoBehaviour
{
    public DateTime start_time;
    public float win_time;
    public Text text_time;
    public GameObject gtext_time;
    public GameObject victory_time;
    public GameObject player;
    public GameObject badtext;
    public AudioSource backgroundMusic;
    public AudioSource victoryMusic;
    // Start is called before the first frame update
    void Start()
    {
        start_time = System.DateTime.Now;
        win_time = PlayerPrefs.GetFloat("WinTime");
    }

    // Update is called once per frame
    void Update()
    {
        float time = win_time - (float)((System.DateTime.Now - start_time).Seconds);
        text_time.text = time.ToString();
        if (time < 0 && gtext_time.activeSelf && !badtext.activeSelf)
        {
            Time.timeScale = 0;
            victory_time.SetActive(true);
            gtext_time.SetActive(false);
            victoryMusic.Play();
            backgroundMusic.Stop();
        }
        if (time < -3)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene (sceneName:"tile_map_implementation");
        }
    }
}
