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
    

    private float time = 0;
    public float waitTime;

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
        if (time == 0)
        {
            Ground();
        }
        else if (time > 0 && time < waitTime)
        {
            time += Time.deltaTime;
            grounded = false;
        }
        else if (time >= waitTime)
        {
            Ground();
            time = 0;
        }
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
        RBPlayer.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        grounded = false;
        time += Time.deltaTime;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground"&& contact.collider == null)

        {
            Vector2 anguloInci = new Vector2(Math.Abs(collision.transform.position.x-collision.GetContact(0).point.x),
                Math.Abs(collision.transform.position.y - collision.GetContact(0).point.y));
            
            float anguloAlfa =(float) Math.Atan(anguloInci.y / anguloInci.x );
            anguloAlfa *= (float)(180/Math.PI);

            Vector2 anguloInci2 = new Vector2(Math.Abs(transform.position.x - collision.GetContact(0).point.x),
                Math.Abs(transform.position.y - collision.GetContact(0).point.y));

            float anguloBeta = (float)(Math.Atan(anguloInci2.y / anguloInci2.x));
            anguloBeta *= (float)(180 / Math.PI);
            Debug.Log(anguloBeta-anguloAlfa);
            float anguloFinal = (float)180-anguloBeta+anguloAlfa;
            transform.Rotate(0,0,anguloFinal);
        }
    }
}
