using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    //Creo una variable estatica para que otros scripts puedan acceder a ella y hago que sea un booleano para verificar si está pausado o no
    public static bool JuegoEstaPausado = false;
    public string escenaMenu;
    public GameObject menuPausaUI;

    // Update is called once per frame
    void Update()
    {
        //Acá pregunto si el botón esc fue presionado, esto para hacer que el juego se pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Si la variable booleana es verdadera, significa que el juego ya estaba pausado y por ende se presionó esc para salir del menu de pausa
            if (JuegoEstaPausado)
            {
                Resumir();
            }
            //En el caso de no ser verdadera el juego va a pausarse
            else
            {
                Pausar();
            }
        }
    }

    public void Resumir()
    {
        Time.timeScale = 1f;
        JuegoEstaPausado = false;
        menuPausaUI.SetActive(false);
    }

    void Pausar()
    {
        menuPausaUI.SetActive(true);
        Time.timeScale = 0;
        JuegoEstaPausado = true;
    }

    public void IrMenu()
    {
        Time.timeScale = 1f;
        JuegoEstaPausado = false;
        menuPausaUI.SetActive(false);
        SceneManager.LoadScene(escenaMenu);
    }
    
    public void CerrarJuego()
    {
        Application.Quit();
    }
}
