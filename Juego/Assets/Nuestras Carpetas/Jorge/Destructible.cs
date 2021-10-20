using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    //Referencia al objeto en "cracked"
    public GameObject destroyedVersion;
    public GameObject enemigo;
    
    public void Destroy()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
        Instantiate(enemigo, transform.position, transform.rotation);
        
    }

}
