using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroRandom : MonoBehaviour
{
    // Start is called before the first frame update
    public int velocidadGiro;
    private int randomVel;
    void Start()
    {
        randomVel = Random.Range(velocidadGiro/2, velocidadGiro);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().Rotate(0, 0, randomVel * Time.deltaTime);
    }
}
