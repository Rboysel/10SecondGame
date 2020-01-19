using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuttaTime : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip musicone;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource.clip = musicone;
        AudioSource.PlayDelayed(14f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
