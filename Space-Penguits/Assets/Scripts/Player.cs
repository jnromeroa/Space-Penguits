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
    private float gravity;
    private int jumpcount;
    [SerializeField] private GameObject musica;
    

    

    void Start()
    {
        RBPlayer = GetComponent<Rigidbody2D>();
        gravity = RBPlayer.gravityScale;
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
    }
    void Update()

    {
        CheckGround();
        /*
        Debug.Log("en tierra?" + grounded);
        Debug.Log("ambos a la vez?" + (Input.GetMouseButtonDown(0) && grounded));*/

        if (Input.GetMouseButtonDown(0) && grounded)
        {
            if(jumpcount == 0)
            {
                PlayMusic();
            }
            Jump();
            jumpcount++;
        }

        Ground();
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
        RBPlayer.gravityScale = 0;
    }
    void Ground()
    {
        if (contact.collider != null)
        {
            grounded = true;
            transform.parent = contact.collider.transform;
            RBPlayer.gravityScale = gravity;
        }
        else
        {
            grounded = false;
            RBPlayer.gravityScale = 0;
            transform.parent = null;
        }
    }
    
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.tag == "Ground")
        {
            transform.rotation = Quaternion.FromToRotation(transform.up, -Physics2D.gravity) * transform.rotation;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "Ground")
        {
            RBPlayer.Sleep();
        }
    }
    public void PlayMusic()
    {
        musica.GetComponent<AudioSource>().Play();
    }

}

