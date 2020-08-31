using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HidingPanel : MonoBehaviour
    
    
{
    public GameObject obje;


    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void _Hiding()
    {


        if (obje.activeSelf==true)
        {
            obje.SetActive(false);
        }
        else
        {
            //    obje.GetComponent<CanvasGroup>().DOFade(1, 0.1f);
            obje.SetActive(true);
        }

        //obje.GetComponent<CanvasGroup>().DOFade(1, 0.1f);


    }


    
}
