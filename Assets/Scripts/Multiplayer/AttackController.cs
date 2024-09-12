using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    Activador activador;
    Movema movemagia;
    public GameObject Audio;

    AudioSource audioAttack;

    void Start()
    {
        activador = GetComponent<Activador>();
        movemagia = GetComponent<Movema>();
        audioAttack = Audio.GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {   
            audioAttack.PlayOneShot(audioAttack.clip);
            activador.Actobjeto();
            movemagia.Move();
        }

    }
}
