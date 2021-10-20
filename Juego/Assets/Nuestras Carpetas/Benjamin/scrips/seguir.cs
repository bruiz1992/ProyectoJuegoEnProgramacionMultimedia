using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguir : MonoBehaviour
{

    public Transform Player;
    public bool Vision, LimiteCercania;
    public LayerMask PlayerLayer;
    public float RadioVision = 0.5f, RadioCercania = 0.1f, Speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vision = Physics2D.OverlapCircle(transform.position,RadioVision,PlayerLayer);
        LimiteCercania = Physics2D.OverlapCircle(transform.position,RadioVision,PlayerLayer);

        //if (LimiteCercania)
       // {
        //    return;
        //}
        //if (Vision)
        //{
            
        
        Vector3 Direccion = Player.position - transform.position;
        transform.localRotation = Quaternion.LookRotation(transform.forward,Direccion);
        transform.position += transform.up * Speed *Time.deltaTime;
       //} 
    }
}
