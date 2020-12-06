using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioVol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mislider;
    void Start()
    {
        DontDestroyOnLoad(mislider.gameObject);
        AudioListener.volume = mislider.GetComponent<Slider>().value;
        Debug.Log(AudioListener.volume);
    }

    // Update is called once per frame
    void Update()
    {
        AudioListener.volume = mislider.GetComponent<Slider>().value;
        Debug.Log(AudioListener.volume);
    }
}
