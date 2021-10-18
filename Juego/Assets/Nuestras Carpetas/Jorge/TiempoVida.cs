using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoVida : MonoBehaviour
{
    public float tiempo = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(tiempo > 0)
        {
            tiempo -= Time.deltaTime;
        }
        if(tiempo <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
