using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnomation : MonoBehaviour
{
    public Animator animator;

    public void ActivedNPC(int animacion)
    {
        animator.SetInteger("Transicion", animacion);
    }
    

}
