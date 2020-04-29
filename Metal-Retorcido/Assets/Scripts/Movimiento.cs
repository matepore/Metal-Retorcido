using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimiento : MonoBehaviour
{
    public Text movimiento;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Heroe")
        {
            movimiento.text = "Te puedes mover usando las letras A S W D o las Flechas";
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Heroe")
        {
            movimiento.text = "";
        }
    }
}
