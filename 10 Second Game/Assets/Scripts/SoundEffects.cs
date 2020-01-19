using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip musicone;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            AudioSource.clip = musicone;
            AudioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            AudioSource.clip = musicone;
            AudioSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            AudioSource.clip = musicone;
            AudioSource.Stop();
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            AudioSource.clip = musicone;
            AudioSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AudioSource.clip = musicone;
            AudioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            AudioSource.clip = musicone;
            AudioSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            AudioSource.clip = musicone;
            AudioSource.Stop();
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            AudioSource.clip = musicone;
            AudioSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
