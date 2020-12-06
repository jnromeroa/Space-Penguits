using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Tilemaps;

public class Parallax : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cam;
    public float relativeMove = .3f;
    public bool lockY = false;

   

    void Star()
    {
     
    }
    void Update()
    {

        if (lockY)
        {
            transform.position = new Vector2(cam.position.x * relativeMove, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(cam.position.x * relativeMove, cam.position.y * relativeMove);
        }
        
    }


}
