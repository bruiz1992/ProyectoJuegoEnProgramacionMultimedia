using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public float Vida = 100;

    public Image BarraVida; 
   

    // Update is called once per frame
    void Update()
    {
        Vida = Mathf.Clamp(Vida, 0, 100);
        BarraVida.fillAmount = Vida / 100;
    }
}
