using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class EventManagerIntro : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject textoIntro;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject corazon;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            textoIntro.GetComponentInChildren<Animator>().SetBool("Clicked", true);
            
            StartCoroutine(corrutina());
            
        }
    }
    IEnumerator corrutina()
    {
        

        yield return new WaitForSeconds(0.5f);
        panel.GetComponentInChildren<Animator>().SetBool("Clicked", true);
        
        yield return new WaitForSeconds(3f);
        corazon.GetComponentInChildren<Animator>().SetBool("Clicked", true);

    }

}
