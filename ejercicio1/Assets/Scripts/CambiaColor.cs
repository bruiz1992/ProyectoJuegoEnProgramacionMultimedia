using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColor : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        Renderer rend = GetComponent<Renderer>();
        Color colorAleatorio = new Color (  Random.Range(0.0F, 1.0F),
                                            Random.Range(0.0F, 1.0F),
                                            Random.Range(0.0F, 1.0F),
                                            1.0F);
        rend.material.color = colorAleatorio;



    }
}
