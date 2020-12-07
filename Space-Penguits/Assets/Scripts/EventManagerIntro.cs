using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManagerIntro : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject textoIntro;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject corazon;
    [SerializeField] private GameObject maria;
    [SerializeField] private GameObject celular;
    [SerializeField] private GameObject chat;
    [SerializeField] private GameObject ultimaAnim;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            toNextScene();
        }
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
        yield return new WaitUntil(()=>Input.GetMouseButtonDown(0));
        celular.GetComponentInChildren<Animator>().SetBool("Clicked", true);
        maria.GetComponentInChildren<Animator>().SetBool("Clicked", true);
        yield return new WaitForSeconds(1f);
        chat.GetComponentInChildren<Animator>().SetBool("Clicked", true);
        yield return new WaitForSeconds(15f);
        ultimaAnim.GetComponentInChildren<Animator>().SetBool("Clicked", true);
        yield return new WaitForSeconds(15f);
        toNextScene();


    }
    void toNextScene()
    {
        SceneManager.LoadScene("Menu");
    }

}
