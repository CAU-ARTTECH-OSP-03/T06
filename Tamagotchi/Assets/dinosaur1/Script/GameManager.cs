using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gopanel;
    AudioSource losesound;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        losesound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void GameOver()
    {
        losesound.Play();
        Time.timeScale = 0;
        gopanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("maindisplay");
    }
}
