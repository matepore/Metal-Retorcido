using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoObjetivo : MonoBehaviour
{
    public Text objetivo;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Heroe")
        {
            objetivo.text = "Para ganar el juego debes eliminar a todos los autos oponentes. Destruye ese auto para terminar este escenario";
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Heroe")
        {
            objetivo.text = "";
        }
    }
}
