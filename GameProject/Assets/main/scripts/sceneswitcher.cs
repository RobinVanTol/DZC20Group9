using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitcher : MonoBehaviour
{
    public GameObject player;
    public string scene_name;
    public float win_time;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("X") != 0 && PlayerPrefs.GetFloat("C") == 1)
        {
            player.transform.position = new Vector3(PlayerPrefs.GetFloat("X")+2, PlayerPrefs.GetFloat("Y"), PlayerPrefs.GetFloat("Z"));
            Debug.Log(PlayerPrefs.GetFloat("X")+2);
        }
    }


    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerPrefs.SetFloat("X", player.transform.position.x);
        PlayerPrefs.SetFloat("Y", player.transform.position.y);
        PlayerPrefs.SetFloat("Z", player.transform.position.z);
        if (scene_name == "hackerslap")
        {
            PlayerPrefs.SetFloat("WinTime", win_time);
        }
        PlayerPrefs.SetFloat("C", 1);
        SceneManager.LoadScene (sceneName:scene_name);
        gameObject.SetActive(false);
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("C", 0);
    }
}
