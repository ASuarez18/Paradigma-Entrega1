using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 Script que se encarga de llamar el encendido y apagado de cada vela el cual será llamado por el jugador con un Raycast
 */
public class CandleBehavior : MonoBehaviour
{
    public void encenderVela() //Funcion de encendido de vela
    {
        Debug.Log("Vela " + this.gameObject.name + " Encendida");
        gameObject.transform.GetChild(0).gameObject.SetActive(true); //Tomamos al hijo de la vela, que en este caso es la flama y lo activamos
        gameObject.transform.GetComponentInParent<CandleManager>().candles.Add(gameObject.transform.GetChild(0).gameObject); //Añadimos esta flama como gameObject a un arreglo dentro del controlador del puzzle de velas para verificar si el jugador realiza el encendido de las velas por completo
    }

    public void apagarVela() //Funcion de apagado de vela
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false); //Se llama a la desactivación de la flama de la vela ya que el jugador cometio un error
    }
}
