using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planetas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().Rotate(0, 0, 1);
    }
}
