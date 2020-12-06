using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Tilemaps;

public class Parallax : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float scrollSpeed = 0.3f;
    [SerializeField] GameObject viewTarget; //cam
    [SerializeField] bool xOnly = true;

    Tilemap tilemap;

    void Star()
    {
        tilemap = GetComponent<Tilemap>();
    }
    void Update()
    {
        float newXPos = viewTarget.transform.position.x * scrollSpeed;
        float newYPos = viewTarget.transform.position.y * scrollSpeed;

        if (xOnly)
        {
            tilemap.transform.position = new Vector3(newXPos, tilemap.transform.position.y, tilemap.transform.position.z);
        }
        else
        {
            tilemap.transform.position = new Vector3(newXPos, newYPos, tilemap.transform.position.z);
        }
        
    }


}
