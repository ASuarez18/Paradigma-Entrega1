using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    Activador activador;
    Movema movemagia;
    void Start()
    {
        activador = GetComponent<Activador>();
        movemagia = GetComponent<Movema>();

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            activador.Actobjeto();
            movemagia.Move();
        }

    }
}
