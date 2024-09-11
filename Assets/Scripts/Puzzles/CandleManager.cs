using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleManager : MonoBehaviour
{
    public Animator doorAnimator;
    public List<GameObject> candles; //Lista en la que se insertaran las velas para el puzzle

    // Start is called before the first frame update
    void Start()
    {
        candles = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(candles.Count >= 5)
        {
            Debug.Log("Abrir reja");
            doorAnimator.SetTrigger("OpenDoor");
            candles.Clear();
        }
        Debug.Log("Cantidad de velas:" + candles.Count);
    }
}
