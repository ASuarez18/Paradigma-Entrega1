using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movema : MonoBehaviour
{
    public Transform targetPosition;
    public GameObject bolita;
    public float moveSpeed ;

    public void Move()
    {
        StartCoroutine(MoveBolita());
    }

    private IEnumerator MoveBolita()
    {
        while (Vector3.Distance(bolita.transform.position, targetPosition.position) > 0.01f)
        {
            bolita.transform.position = Vector3.MoveTowards(bolita.transform.position, targetPosition.position, moveSpeed * Time.deltaTime);
            yield return null; // Espera hasta el siguiente frame
        }

        Destroy(bolita);
        Debug.Log("Destruyendo");
    }
}
