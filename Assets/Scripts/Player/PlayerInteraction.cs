using System;
using UnityEngine;
using TMPro;
using System.Collections;

public class PlayerInteraction : MonoBehaviour
{
    
    public Camera mainCamera; 
    public float rayDistance = 2f;
    public TextMeshProUGUI interactText, elementText, quantityText;
    int quantiTyElements = 0;
    private AudioSource audioSourceElement;
    public AudioClip audioClipElement;

    private void Start()
    {
        interactText.gameObject.SetActive(false); 
        quantityText.text = quantiTyElements.ToString();
    }

    private void FixedUpdate()
    {
        CheckRayInteraction();
    }

    /// <summary>
    /// Function that verifies and searches for a ray collision with a collider of a door and/or candles
    /// </summary>
    void CheckRayInteraction()
    {
        Ray ray = mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        RaycastHit hit;

        Debug.DrawRay(ray.origin, ray.direction , Color.red);

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            if (hit.collider.tag == "Door" || hit.collider.tag == "Candle" || hit.collider.tag == "Element") {
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
                        hit.collider.gameObject.GetComponent<CandleBehavior>().encenderVela();
                        hit.collider.tag = "Untagged";
                    }
                }

                // Element Collition
                if (hit.collider.tag == "Element")
                {
                    if (Input.GetKey(KeyCode.E))
                    {
                        audioSourceElement = hit.collider.gameObject.GetComponent<AudioSource>();
                        audioSourceElement.PlayOneShot(audioClipElement);
                        // Obtain element
                        hit.collider.gameObject.GetComponent<MeshRenderer>().enabled = false;
                        hit.collider.tag = "Untagged";
                        StartCoroutine(ElementMessage());
                        quantityText.text = (++quantiTyElements).ToString();
                    }
                }
                // Debug.Log("El raycast ha golpeado: " + hit.collider.tag);
            }
            else
                interactText.gameObject.SetActive(false);
        }
        else
            interactText.gameObject.SetActive(false);
    }

    IEnumerator ElementMessage()
    {
        yield return new WaitForSeconds(0.5f);
        elementText.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        elementText.gameObject.SetActive(false);
    }
}
