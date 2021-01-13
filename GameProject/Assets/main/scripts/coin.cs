using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public string coin_string;
    public AudioSource audioSource;
    void Start()
    {
        if (PlayerPrefs.GetFloat(coin_string) == 0 && PlayerPrefs.GetFloat("C") == 1)
        {
            gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetFloat("C") == 0)
        {
            PlayerPrefs.SetFloat(coin_string, 1);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerPrefs.SetFloat(coin_string, 0);
        audioSource.Play();
        gameObject.SetActive(false);
    }
}
