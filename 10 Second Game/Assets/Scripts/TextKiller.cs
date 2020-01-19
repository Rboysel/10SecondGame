using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextKiller : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip musicone;
    void Start()
    {
        Destroy(gameObject, 2);
        AudioSource.clip = musicone;
        AudioSource.Play();

}

    void Update()
    {

    }
}