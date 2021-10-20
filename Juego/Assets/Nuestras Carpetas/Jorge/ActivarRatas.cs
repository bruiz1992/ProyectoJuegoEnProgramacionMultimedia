using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarRatas : MonoBehaviour
{

    public GameObject rata1;
    public GameObject rata2;
    public GameObject rata3;
    public GameObject rata4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider playerSube)
    {
       rata1.SetActive(true);
       rata2.SetActive(true);
       rata3.SetActive(true);
       rata4.SetActive(true);
    }
}
