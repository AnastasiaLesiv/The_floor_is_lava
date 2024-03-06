using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource audio = new AudioSource();
    // Start is called before the first frame update
    void Start()
    {
        audio.Play();
    }

    
}
