using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarColor : MonoBehaviour
{
    // Componente MeshRenderer
    public MeshRenderer thisRenderer;
    // Crea un valor de cambio de tiempo de recepción constante
    float shankeTime = 0f;
    // Si empezar a parpadear
    public bool isShake = false;

    
    // Update is called once per frame
    void Update ()
    {
        ToChangeColor();
    }
    /// <summary>
    /// Cambiar la lógica del color
    /// </summary>
    void ToChangeColor()
    {
        if (isShake)
        {
            shankeTime += Time.deltaTime;
            if (shankeTime % 1 > 0.5f)
            {
                thisRenderer.material.color = Color.blue;
            }
            else
            {
                thisRenderer.material.color = Color.white;
            }
        }
    }
}
