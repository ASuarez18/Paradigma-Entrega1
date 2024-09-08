using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAEnemy : MonoBehaviour
{
    private Transform target;
    public float speed {get; set; }
     
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
       
    }

    void Update()
    {
        // Movimiento del enemigo al jugador
        transform.position = Vector3.MoveTowards(transform.position,target.position,speed * Time.deltaTime);
        // Rotación del enemigo hacia el jugador
        Vector3 direction = target.position - transform.position;
        direction.y = 0; // Mantén la rotación solo en el eje Y para evitar que el enemigo se incline hacia arriba o abajo.
        transform.rotation = Quaternion.LookRotation(direction);
    }
}
