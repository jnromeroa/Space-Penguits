﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosFlotando : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D objectRB;
    public float speed;
    void Start()
    {
       
        objectRB = GetComponent<Rigidbody2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "CameraCollider")
        {
            objectRB.velocity = new Vector2(Random.Range(-speed, speed), Random.Range(-speed, speed));
        }
    }
    

}
