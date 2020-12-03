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
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Physics2D.gravity = transform.position - collision.gameObject.transform.position;

            CamaraRig.GetComponent<CameraMovement>().TowardsNextPlanet(transform.position, nextPlanet.transform.position);
            /*CamaraRig.transform.position = transform.Translate(
            new Vector2((transform.position.x + nextPlanet.transform.position.x) / 2,
            (transform.position.y + nextPlanet.transform.position.y) / 2));*/
            
        }
    }
    
}
