using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColor : MonoBehaviour
{
   Color lerpedColor = Color.black;

    void Update()
    {
        lerpedColor = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1));
    }
}