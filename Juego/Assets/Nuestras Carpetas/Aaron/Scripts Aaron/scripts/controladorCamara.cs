using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorCamara : MonoBehaviour
{
// se puede hacer de cualquiera de las dos maneras.
    private Transform PosicionBola;
    private GameObject laBola;
    
    void Start()
    {
        laBola = GameObject.Find("bola");
        PosicionBola = laBola.GetComponent<Transform>();

        // transform.position = PosicionBola.position - Vector3.forward * 2;
        transform.position = PosicionBola.position + Vector3.up * 2;
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PosicionBola.position - Vector3.forward * 200;
        transform.position = PosicionBola.position + Vector3.up * 2;
    }
}
