using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Planetas : MonoBehaviour
{
    public float velocidadGiro;
    public  float velocidadCamara;
    private GameObject CamaraRig;
    public GameObject nextPlanet;
    

    void Start()
    {
        CamaraRig = GameObject.Find("CameraRig");
    }

    
    void Update()
    {
        GetComponent<Transform>().Rotate(0, 0, velocidadGiro);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Physics2D.gravity = transform.position - collision.gameObject.transform.position;
            
            CamaraRig.transform.position = Vector3.MoveTowards(CamaraRig.transform.position, 
                new Vector3((transform.position.x+nextPlanet.transform.position.x)/2,
                (transform.position.y + nextPlanet.transform.position.y) / 2), velocidadCamara * Time.deltaTime);
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
