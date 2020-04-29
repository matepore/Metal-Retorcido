using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoVida : MonoBehaviour
{
    public Text vida;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Heroe")
        {
            vida.text = "Este objeto es un Health Pack, te sanará cuando lo toques";
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Heroe")
        {
            vida.text = "";
        }
    }
}
