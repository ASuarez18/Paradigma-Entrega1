using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator animator;
    int Transicion = 0;
    AudioSource audioSource;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        Transicion += 1;
        audioSource.PlayOneShot(audioSource.clip);
        animator.SetInteger("Transicion", Transicion);

    }
}
