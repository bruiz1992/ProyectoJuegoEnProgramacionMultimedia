using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipularVida : MonoBehaviour
{
    
    VidaPlayer playerVida;
    public int cantidad;
    public float damageTime;
    float currentDamageTime;



    void Start()
    {
     playerVida = GameObject.FindWithTag("Player").GetComponent<VidaPlayer>();

    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other){
    {
     if (other.tag =="Player")
     {
        currentDamageTime += Time.deltaTime;
        if(currentDamageTime > damageTime)
        {
            playerVida.Vida += cantidad;
            currentDamageTime = 0.0f;

        }
     }   }
    }
}
