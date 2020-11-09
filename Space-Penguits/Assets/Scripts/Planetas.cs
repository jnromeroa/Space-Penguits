using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planetas : MonoBehaviour
{
    public float velocidadGiro;

    void Start()
    {
        
    }

    
    void Update()
    {
        GetComponent<Transform>().Rotate(0, 0, velocidadGiro);
    }
}
