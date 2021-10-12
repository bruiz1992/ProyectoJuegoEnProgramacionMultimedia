using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulsar2 : MonoBehaviour
{
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
                if (Input.GetKeyUp(KeyCode.Space))
                {
// La barra de espacio estaba presionada y se ha liberado.
                        Debug.Log ("La barra de espacio estaba presionada y se ha liberado.");

                }
                if (Input.GetButtonDown("Fire1"))
                {
// Utilizando la configuración de las entradas en Unity en Edit / Project Settings / Input Manager..
                }
                if (Input.GetKeyDown(KeyCode.Space))
                {
// La barra de espacio se ha presionado.
                }
                if (Input.GetMouseButtonDown(0))
                {
// El botón izqdo del ratón se ha presionado.
                }
        }
}