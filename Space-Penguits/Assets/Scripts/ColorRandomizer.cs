using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandomizer : MonoBehaviour
{
    // Start is called before the first frame update
    public Color[] colores = new Color[3];
    public Color A;
    public Color B;
    public Color C;
    void Start()
    {
        colores[0] = A;
        colores[1] = B;
        colores[2] = C;
        GetComponent<Camera>().backgroundColor = colores[Random.Range(0, colores.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
