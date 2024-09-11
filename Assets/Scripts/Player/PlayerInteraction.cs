using System;
using UnityEngine;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    
    public Camera mainCamera; 
    public float rayDistance = 2f;
    public TextMeshProUGUI interactText;

    private void Start()
    {
        interactText.gameObject.SetActive(false); 
    }

    private void FixedUpdate()
    {
        CheckRayInteraction();
    }

    /// <summary>
    /// 
    /// </summary>
    void CheckRayInteraction()
    {
        Ray ray = mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        RaycastHit hit;

        Debug.DrawRay(ray.origin, ray.direction , Color.red);

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            if (hit.collider.tag == "Door" || hit.collider.tag == "Candle") {
                interactText.gameObject.SetActive(true);
                // Door Collition
                if (hit.collider.tag == "Door")
                {
                    if (Input.GetKey(KeyCode.E))
                    {
                        hit.collider.gameObject.GetComponent<Animator>().SetTrigger("TriggerAnimation");
                        hit.collider.tag = "Untagged"; //TODO: Deshabilitar para que no muestre mensaje
                    }
                }
                // Candle Collition
                if (hit.collider.tag == "Candle")
                {
                    if (Input.GetKey(KeyCode.E))
                    {
                        // Ignite Candles
                        throw new NotImplementedException();
                    }
                }
                Debug.Log("El raycast ha golpeado: " + hit.collider.tag);
            }
            else
                interactText.gameObject.SetActive(false);
        }
        else
            interactText.gameObject.SetActive(false);
    }
}
