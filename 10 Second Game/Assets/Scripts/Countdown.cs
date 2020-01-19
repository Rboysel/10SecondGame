using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public float timeLeft = 12.0f;
    public Text timeText;
    public AudioSource AudioSource;
    public AudioClip musicone;
    public GameObject gameObjectB;


    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeText.text = (timeLeft).ToString("Time Left:0");
        
            if (timeLeft < 0)
        {
            AudioSource.clip = musicone;
            AudioSource.Play();
            Destroy(gameObjectB);
            Time.timeScale = 0;
        }

    }
}