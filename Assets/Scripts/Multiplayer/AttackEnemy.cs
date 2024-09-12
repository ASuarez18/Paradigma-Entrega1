using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Attackenemy : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }


    void Update()
    {
        //if the player press the click left mouse button
        if (Input.GetMouseButtonDown(0))
        {   
            animator.SetInteger("Transicion", 3);
        }
            

        
    }
}
