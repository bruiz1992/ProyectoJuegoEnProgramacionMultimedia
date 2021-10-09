using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLerp : MonoBehaviour
{
   private Transform    vectorPlayer;
   private GameObject   posicionA;
   private GameObject   posicionB;
   private Vector3      posA;
   private Vector3      posB;

   private Vector3 subir;

    void Start()
    {
          subir = new Vector3(0.0f, 1.0f, 0.0f); 

        vectorPlayer =gameObject.GetComponent<Transform>();
        posicionA = GameObject.Find("PosicionA");
        posicionB = GameObject.Find("PosicionB");
        posA = posicionA.transform.position;
        posB = posicionB.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        vectorPlayer.transform.position = Vector3.Lerp(posA,posB,Time.time*0.2f) + subir;

       // vectorPlayer.transform.position = Vector3.Lerp(posA,posB,Time.time*0.2f);
      //  vectorPlayer.transform.position = Vector3.Lerp(vectorPlayer.transform.position,posB,Time.time*0.002f);


    }
}
