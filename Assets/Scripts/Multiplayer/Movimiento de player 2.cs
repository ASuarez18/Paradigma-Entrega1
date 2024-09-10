using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientodeplayer2 : MonoBehaviour
{    
    public Transform targetPosition;
    public float moveSpeed = 2f;
    public float rotationSpeed = 5f;


    void Update()
    {
        // Mover hacia el target usando MoveTowards
        transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, moveSpeed * Time.deltaTime);

        // Calcular dirección hacia el target
        Vector3 direction = targetPosition.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction);

        // Rotar hacia el target usando RotateTowards
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
