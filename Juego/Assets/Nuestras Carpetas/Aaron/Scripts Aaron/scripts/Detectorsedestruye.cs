using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectorsedestruye : MonoBehaviour
{
   private GameObject laBola;
   private GameObject elCristal;
    
    void Awake()
    {
        laBola = GameObject.Find("Bola");
        elCristal = GameObject.Find("Suelo");
    }

   
    void OnTriggerEnter(Collider objetoQueHaEntrado)
    {
        
        if (objetoQueHaEntrado.name == "Bola")
        {
            Debug.Log ("Ha roto el cristal");
            Destroy(elCristal);
        }
    }
}
