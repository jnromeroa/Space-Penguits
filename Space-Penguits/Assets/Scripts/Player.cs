using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D RBPlayer;
    public float jumpForce;
    [SerializeField] private bool grounded;
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
        Debug.DrawLine(transform.position, -transform.up, Color.red);
        //contact = Physics2D.Raycast(transform.position, feet*longRay, longRay, groundLayer);
        //Debug.DrawRay(transform.position, feet * longRay, Color.red);
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
}
