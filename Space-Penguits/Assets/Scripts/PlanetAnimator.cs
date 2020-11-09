using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator planetAnim;
    void Start()
    {
        planetAnim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag =="Player")
           
        {
            planetAnim.SetBool("Beat", true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Player")

        {
            planetAnim.SetBool("Beat", false);
        }
    }
}
