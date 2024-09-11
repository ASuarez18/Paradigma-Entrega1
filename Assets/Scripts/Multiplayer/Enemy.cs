using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator animator;
    int Transicion = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player2")
        {
            animator.SetInteger("Transicion", 1);
        }
        if (other.gameObject.tag == "Player1")
        {
            animator.SetInteger("Transicion", 2);
        }
    }
}
