using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score;
    Text scoreText;

    float timer;
    float maxTime;
    AudioSource scoresound;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();
        maxTime = 0.1f;
        scoresound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= maxTime)
        {
            score++;
            scoreText.text = score.ToString("00000");
            timer = 0;
            if(score % 100 == 0)
            {
                scoresound.Play();
                Time.timeScale += 0.1f;
            }
        }
    }
}
