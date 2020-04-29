using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoDisparar : MonoBehaviour
{
    public Text disparar;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.name == "Heroe")
        {
            disparar.text = "Puedes disparar con la tecla CTRL o el Clic izquierdo del mouse";
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Heroe")
        {
            disparar.text = "";
        }
    }
}
