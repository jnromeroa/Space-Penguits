using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorRandomizer : MonoBehaviour
{
    // Start is called before the first frame update
    public Color[] colores = new Color[3];
    public Color A;
    public Color B;
    public Color C;
    public GameObject planeta;
    public Sprite planetA;
    public Sprite planetB;
    public Sprite planetC;
    private Image miImagen;

    void Start()
    {
        int selector;
        miImagen = planeta.GetComponent<Image>();
        
        colores[0] = A;
        colores[1] = B;
        colores[2] = C;
        selector = Random.Range(0, colores.Length);
        GetComponent<Camera>().backgroundColor = colores[selector];
        switch (selector)
        {
            case 0: 
                miImagen.sprite = planetA;
                break;
            case 1:
                miImagen.sprite = planetB;
                break;
            case 2:
                miImagen.sprite = planetC;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
