using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public static bool Perdiste = false;
    public Character jugador;
    public GameObject menuGameOverUI;
    public string escenaMenu;
    public string escenaBatalla;

    // Update is called once per frame
    void Update()
    {
        if(jugador == null)
        {
            if (!Perdiste)
            {
                Perder();
            }
            
        }
    }

    void Perder()
    {
        menuGameOverUI.SetActive(true);
        Perdiste = true;
    }

    public void Retry()
    {
        Perdiste = false;
        menuGameOverUI.SetActive(false);
        SceneManager.LoadScene(escenaBatalla);
    }

    public void IrMenu()
    {
        Perdiste = false;
        menuGameOverUI.SetActive(false);
        SceneManager.LoadScene(escenaMenu);
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }
}
