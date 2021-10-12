using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{

    private GameObject elPlayer;
    private GameObject elDetector;
    private GameObject laPuerta;
    

    // Start is called before the first frame update
    void Start()
    {
        elPlayer = GameObject.Find("Player");
        elDetector = GameObject.Find("Detector");
        laPuerta = GameObject.Find("Puerta");
        
    }

   
    void OnTriggerEnter(Collider playerSube)
    {
        
        if (playerSube.name == "Player")
        {
            Debug.Log ("Puerta Abierta");
            Destroy(laPuerta);
        }
}
}