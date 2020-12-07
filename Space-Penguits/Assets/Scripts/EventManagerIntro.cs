using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class EventManagerIntro : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject textoIntro;
    [SerializeField] private GameObject panel;
    
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
        yield return new WaitForSeconds(2f);
        panel.GetComponentInChildren<Animator>().SetBool("Clicked", true);
    }

}
