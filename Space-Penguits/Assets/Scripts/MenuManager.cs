using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject musica;
    private void Start()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene("Nivel Electro");
        musica.GetComponent<AudioSource>().Stop();

    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
}
