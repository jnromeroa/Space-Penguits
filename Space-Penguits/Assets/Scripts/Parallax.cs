using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Parallax : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 length;
    private Vector2 startpos;
    public GameObject cam;
    public float parallaxEffect;
    void Start()
    {
        startpos = transform.position;
        
        
    }

    
    void Update()
    {
        Vector2 dist = (cam.transform.position * parallaxEffect);
        transform.position = new Vector2(startpos.x + dist.x, startpos.y + dist.x);
    }
}
