using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    private GameObject laBola;
    
    void Awake()
    {
        laBola = GameObject.Find("Bola");
    }

   
    void OnTriggerEnter(Collider objetoQueHaEntrado)
    {
        
        if (objetoQueHaEntrado.name == "Bola")
        {
            Debug.Log ("Ha caido la bola al vacio");
            Destroy(laBola);
        }
    }
}
