using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D RBPlayer;
    public float jumpForce;
    public bool grounded;
    public float longRay;
    [SerializeField] LayerMask groundLayer;
    private RaycastHit2D contact;
    

    

    void Start()
    {
        RBPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        CheckGround();
        if (Input.GetButtonDown("Jump") && grounded)
        {
            Jump();
        }
        
        Ground();
    }
    void Update()

    {
        
    }
    void CheckGround()
    {
        contact = Physics2D.Raycast(transform.position, -transform.up, longRay, groundLayer);
        //Debug.DrawLine(transform.position, -transform.up, Color.red);
       
    }
    void Jump()
    {
        RBPlayer.velocity = transform.up * jumpForce;
        grounded = false;
        
    }
    void Ground()
    {
        if (contact.collider != null)
        {
            grounded = true;
            transform.parent = contact.collider.transform;
        }
        else
        {
            grounded = false;
            transform.parent = null;
        }
    }
    
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        transform.rotation = Quaternion.FromToRotation(transform.up, -Physics2D.gravity) * transform.rotation;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        RBPlayer.Sleep();
    }

}

