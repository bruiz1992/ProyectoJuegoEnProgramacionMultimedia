using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public int movementSpeed = 6;
    public int turnSpeed = 3;
    public GameObject camera;
    float strafe = 0;
    float forward = 0;
    float diagonalMix = 0;
    bool isMoving = false;
    Animator animator;
    Rigidbody rigidbody;

    void Start(){
        //animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        Debug.Log(Input.GetJoystickNames().ToString());
    }

    void Update()
    {
        strafe = Input.GetAxis("Horizontal");
        forward = Input.GetAxis("Vertical");
        /*forward = 0;
        strafe = 0;
        if(Input.GetKey(KeyCode.W)){forward = 1;}
        if(Input.GetKey(KeyCode.S)){forward = -1;}
        if(Input.GetKey(KeyCode.D)){strafe = 1;}
        if(Input.GetKey(KeyCode.A)){strafe = -1;}*/

        if(strafe == 0 && forward == 0){
            isMoving = false;
        }else{
            isMoving = true;
        }

        diagonalMix = (-Mathf.Abs(strafe) + Mathf.Abs(forward))/2 + 0.5f;

        //Para mando (Provisional)
        //transform.Translate(new Vector3(strafe, 0, forward) * movementSpeed * Time.deltaTime);
        //Para ratón (Provisional)
        transform.Translate(new Vector3(strafe, 0, forward).normalized * movementSpeed * Time.deltaTime);
        
        transform.rotation = Quaternion.Euler(0, camera.transform.eulerAngles.y, 0);
        
        applyAnimations();
    }

    void applyAnimations(){
        animator.SetFloat("forward", forward);
        animator.SetFloat("strafe", strafe);
        animator.SetFloat("diagonalMix", diagonalMix);
        animator.SetBool("isMoving", isMoving);

        //isMoving = false;
    }

}
