using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propiedades : MonoBehaviour
{

    private GameObject esferaMalvada;
    private float distanciaXparaDespertarse = 1.0f;

    void Start()
    {
        esferaMalvada = GameObject.Find("aranya");

    }

    // Update is called once per frame
    void Update()
    {

        float distanciaX = esferaMalvada.transform.position.x - transform.position.x;

        //si la distancia es menor a 0 por sus posicion la transformamos a positivo

        if(distanciaX < 0) distanciaX = - distanciaX;

        if(distanciaX < distanciaXparaDespertarse) Debug.Log("El bicho se desperto");



    }
}
