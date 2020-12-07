using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Immortal : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource miAudio;
    
    void Start()
    {

        DontDestroyOnLoad(this.gameObject);
        miAudio = GetComponent<AudioSource>();
        miAudio.Play();
            
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
