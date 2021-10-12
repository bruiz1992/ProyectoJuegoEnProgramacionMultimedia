using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorBola : MonoBehaviour
{
    private int velocidadLineal = 20;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(
                transform.position.x - velocidadLineal * Time.deltaTime,
                transform.position.y,
                transform.position.z
            );
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(
                transform.position.x + velocidadLineal * Time.deltaTime,
                transform.position.y,
                transform.position.z
            );
        }
         if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z + velocidadLineal * Time.deltaTime
            );
        }
         if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z - velocidadLineal * Time.deltaTime
            );
        }



        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y + 50 * Time.deltaTime,
                transform.position.z
            );
        }

    }
    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.tag=="pared")
        {
            Renderer rend = GetComponent<Renderer>();
            Color unColor = new Color ( Random.Range(0.0F, 1.0F),
                                        Random.Range(0.0F, 1.0F),
                                        Random.Range(0.0F, 1.0F),
                                        1.0F
                                        );
            rend.material.color = unColor;
        }
        if(coll.gameObject.tag=="cilindro")
        {
            Destroy (coll.gameObject, 0f);
        }
    }
}
