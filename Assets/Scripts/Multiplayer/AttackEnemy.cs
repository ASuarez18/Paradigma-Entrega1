using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Attackenemy : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        //if the player press the click left mouse button
        if (Input.GetMouseButtonDown(0))
        {   
            audioSource.PlayOneShot(audioSource.clip);
            animator.SetInteger("Transicion", 3);
        }
            

        
    }
}
