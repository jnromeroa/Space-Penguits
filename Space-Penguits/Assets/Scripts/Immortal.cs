using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Immortal : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource miAudio;
    private bool playeable = true;
    void Start()
    {

        DontDestroyOnLoad(this.gameObject);
        miAudio = GetComponent<AudioSource>();
        if (playeable)
        {
            miAudio.Play();
            playeable = false;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
