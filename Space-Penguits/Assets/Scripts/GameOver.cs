using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject CManager;
    public enum DeathType {Stranded, Unmotivated, Crashed}
    public DeathType deathby;

    private void Start()
    {
        CManager = GameObject.Find("CanvasManager");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(deathby == DeathType.Stranded)
        {
            if (collision.tag == "Player")
            {
                CManager.GetComponent<CanvasManager>().varadoCount++;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }
        }
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (deathby == DeathType.Unmotivated)
        {
            if (collision.tag == "Player")
            {
                CManager.GetComponent<CanvasManager>().desmotivCount++;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }
        }
    }
}
