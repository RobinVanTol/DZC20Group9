using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Usuck : MonoBehaviour
{
    public GameObject player;
    public GameObject hacker1;
    public GameObject hacker2;
    public GameObject hacker3;
    public GameObject hacker4;
    public GameObject uSuck;
    //public AudioSource failMusic;
    public AudioSource backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool ofc = hacker1.transform.position.y > -9.8 && hacker2.transform.position.y > -9.8 && hacker3.transform.position.y > -9.8 && hacker4.transform.position.y > -9.8;
        if (!ofc)
        {
            //failMusic.Play();
            Time.timeScale = 0;
            uSuck.SetActive(true);
            backgroundMusic.Stop();
            StartCoroutine(WaitForRealSeconds(4));


        }
        //Debug.Log(player.transform.position.y);
    }

    IEnumerator WaitForRealSeconds(float seconds)
    {
        float startTime = Time.realtimeSinceStartup;
        while (Time.realtimeSinceStartup - startTime < seconds)
        {
            yield return null;
        }
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName: "tile_map_implementation");
    }
}
