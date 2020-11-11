using System.Collections;
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
        objectRB.velocity = new Vector2(Random.Range(0, speed), Random.Range(0, speed));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
