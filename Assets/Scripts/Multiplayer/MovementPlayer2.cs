using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movi : MonoBehaviour
{
    public Transform targetPosition;
    public float moveSpeed = 2f;
    public float rotationSpeed = 180f; // en grados por segundo
    private bool isMoving = false; // Para controlar si el movimiento ya ha iniciado

    void Update()
    {
        // Detectar cuando se presiona la tecla Q
        if (Input.GetKeyDown(KeyCode.Q) && !isMoving)
        {
            // Iniciar el movimiento y la rotación
            StartCoroutine(MoverYRotar());
        }
    }

    IEnumerator MoverYRotar()
    {
        isMoving = true; // Evitar que se inicie la corrutina varias veces

        // Mientras el objeto no haya llegado a la posición
        while (Vector3.Distance(transform.position, targetPosition.position) > 0.01f)
        {
            // Mover hacia el target usando MoveTowards
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, moveSpeed * Time.deltaTime);

            // Calcular la dirección hacia el target solo en el eje Y
            Vector3 direction = targetPosition.position - transform.position;
            float targetYRotation = Quaternion.LookRotation(direction).eulerAngles.y;

            // Crear la rotación solo en Y
            Quaternion targetRotation = Quaternion.Euler(0, targetYRotation, 0);

            // Rotar hacia el target solo en el eje Y usando RotateTowards
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Esperar un frame antes de continuar
            yield return null;
        }

        isMoving = false; // Resetear el estado cuando termine el movimiento
    }
}
