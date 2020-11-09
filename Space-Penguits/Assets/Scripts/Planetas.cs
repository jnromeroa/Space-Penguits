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
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Physics2D.gravity = transform.position - collision.gameObject.transform.position;
            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 3;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
    }
}
