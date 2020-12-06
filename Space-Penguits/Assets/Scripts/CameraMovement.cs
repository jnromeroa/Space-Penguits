using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidadCamara;
    public void TowardsNextPlanet(Vector2 currPlanetPos, Vector2 nextPlanetPos)
    {
        transform.position = Vector2.MoveTowards(transform.position,
               new Vector2((currPlanetPos.x + nextPlanetPos.x) / 2,
               (currPlanetPos.y + nextPlanetPos.y) / 2), velocidadCamara * Time.deltaTime);
    }
}
