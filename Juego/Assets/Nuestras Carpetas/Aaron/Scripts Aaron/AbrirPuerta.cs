using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{

    private GameObject elPlayer;
    private GameObject elDetector;
    public GameObject destruible1;
    public GameObject destruible2;
    public GameObject destruible3;
    public GameObject destruible4;

    // Start is called before the first frame update
    void Start()
    {
        elPlayer = GameObject.Find("Player");
        elDetector = GameObject.Find("Detector");
        
        
    }

   
    void OnTriggerEnter(Collider playerSube)
    {
        
        if (playerSube.name == "Player")
        {
            Debug.Log ("Puerta Abierta");
            Destroy(destruible1);
            Destroy(destruible2);
            Destroy(destruible3);
            Destroy(destruible4);
        }
}
}