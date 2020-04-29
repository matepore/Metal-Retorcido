using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuWin : MonoBehaviour
{
    public static bool Ganaste = false;
    public GameObject menuWinUI;
    public string escenaMenu;
    public string escenaBatalla;
    private GameObject[] autos;


    // Update is called once per frame
    void Update()
    {
        autos = GameObject.FindGameObjectsWithTag("Auto");

        if(autos.Length == 1 && autos[0].gameObject.name == "Heroe")
        {
            Ganar();
        }
    }

    void Ganar()
    {
        menuWinUI.SetActive(true);
        Ganaste = true;
    }

    public void Retry()
    {
        Ganaste = false;
        menuWinUI.SetActive(false);
        SceneManager.LoadScene(escenaBatalla);
    }

    public void IrMenu()
    {
        Ganaste = false;
        menuWinUI.SetActive(false);
        SceneManager.LoadScene(escenaMenu);
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }
}
