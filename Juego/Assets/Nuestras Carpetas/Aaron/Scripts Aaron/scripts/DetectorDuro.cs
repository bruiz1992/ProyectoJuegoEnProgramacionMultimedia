using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorDuro : MonoBehaviour
{
    private GameObject laBola;
   private GameObject elCristal;
    
    void Awake()
    {
        laBola = GameObject.Find("Bola");
        elCristal = GameObject.Find("Suelo");
    }

   
    void onCollisionEnter(Collider objetoQueHaEntrado)
    {
        
        if (objetoQueHaEntrado.name == "Bola")
        {
            Debug.Log ("Toco suelo");
            Destroy(elCristal);
        }
    }
}