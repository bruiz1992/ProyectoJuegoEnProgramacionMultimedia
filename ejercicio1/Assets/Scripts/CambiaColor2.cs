using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColor2 : MonoBehaviour
{
     public Color lerpedColor = Color.white;
    
    void Update() {

         Renderer rend = GetComponent<Renderer>();


        lerpedColor = Color.Lerp(Color.red, Color.black, Mathf.PingPong(Time.time, 1));
        rend.material.color = lerpedColor;
    }
}