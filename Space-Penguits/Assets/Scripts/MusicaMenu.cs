using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaMenu : MonoBehaviour
{
    // Start is called before the first frame update
    private static MusicaMenu MMInstance;
    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (MMInstance == null)
        {

            MMInstance = this;



        }
        else
        {
            Object.Destroy(gameObject);
            



        }
    }
}
