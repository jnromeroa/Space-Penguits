using Boo.Lang.Environments;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
 
    [SerializeField] private Image Desmotivado;
    [SerializeField] private Image Varado;
    [SerializeField] private Image Estrellado;
    [SerializeField] private Text DesTxt;
    [SerializeField] private Text VarTxt;
    [SerializeField] private Text EstTxt;
    [SerializeField] private GameObject myCanvas;
    public int desmotivCount = 0;
    public int varadoCount = 0;
    public int EstrellaCount = 0;
    private static CanvasManager CManInstance;
     
    private void Awake()
    {
        DontDestroyOnLoad(this);
        
        if(CManInstance == null)
        {

            CManInstance = this;
            
            

        } else
        {
            Object.Destroy(this);
            Object.Destroy(myCanvas);
            


        }
    }
    void Start()
    {
        
        Desmotivado.color = Color.clear;
        Varado.color = Color.clear;
        Estrellado.color = Color.clear;
    }

    void Update()
    {
        
        
        
        if(desmotivCount > 0)
        {
            Desmotivado.color = Color.white;
            DesTxt.text = "" + desmotivCount;
            
        }
        if (varadoCount > 0)
        {
            Varado.color = Color.white;
            VarTxt.text = "" + varadoCount;
        }
        if (desmotivCount > 0)
        {
            Estrellado.color = Color.white;
            EstTxt.text = "" + EstrellaCount;
        }

    }
}
