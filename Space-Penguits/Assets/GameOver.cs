using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}
