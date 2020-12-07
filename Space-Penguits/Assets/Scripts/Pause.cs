using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text pauseText;
    private static bool isPaused;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        isPaused = GetComponent<Toggle>().isOn;
        if (isPaused)
        {
            Time.timeScale = 0f;
            AudioListener.pause = true;
            pauseText.text = "Pause";
        }
        else
        {
            Time.timeScale = 1f;
            AudioListener.pause = false;
            pauseText.text = "";
        }
    }
}
