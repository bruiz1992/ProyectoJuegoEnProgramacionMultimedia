using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPingPong : MonoBehaviour
{
    private Transform posicionPlataforma;
    private float posX, posY, posZ;
    private readonly float velocidad = 5f, rango = -2f, distancia = 4; 

    void Start()
    {
        posicionPlataforma = gameObject.GetComponent<Transform>();
        posX = posicionPlataforma.transform.position.x;
        posY = posicionPlataforma.transform.position.y;
        posZ = posicionPlataforma.transform.position.z;
    }

   
    void Update()
    {
        posX = Mathf.PingPong(Time.time*velocidad, distancia) + rango;
        posicionPlataforma.transform.position = new Vector3 (posX, posY, posZ);
    }
}
