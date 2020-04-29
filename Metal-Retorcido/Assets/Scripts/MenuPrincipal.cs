using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public string escenaJugar;
    public string howtoPlay;

    public void Jugar()
    {
        SceneManager.LoadScene(escenaJugar);
    }

    public void HowtoPlay()
    {
        SceneManager.LoadScene(howtoPlay);
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }
}
