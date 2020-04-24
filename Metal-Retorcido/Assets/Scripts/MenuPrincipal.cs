using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public string escenaJugar;

    public void Jugar()
    {
        SceneManager.LoadScene(escenaJugar);
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }
}
