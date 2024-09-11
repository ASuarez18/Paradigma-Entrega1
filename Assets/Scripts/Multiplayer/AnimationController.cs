using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public  void cambiarAnimacion(int animacion)
    {
        animator.SetInteger("Transicion", animacion);
    }

}
