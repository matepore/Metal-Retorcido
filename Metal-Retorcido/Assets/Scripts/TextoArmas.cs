using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoArmas : MonoBehaviour
{
    public Text armas;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Heroe")
        {
            armas.text = "Estos objetos son armas que te puedes equipar, son mas fuertes que la basica";
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Heroe")
        {
            armas.text = "";
        }
    }
}
