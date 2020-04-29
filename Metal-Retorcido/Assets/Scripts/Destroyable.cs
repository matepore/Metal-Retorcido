using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    public int life;
    public int maxLife = 300;

    public HealthBar barraVida;

    void Start()
    {
        //Seteo la vida maxima en la barra de vida para que no empiece de cero
        life = maxLife;
        barraVida.SetearVidaMaxima(maxLife);
    }

    void Update()
    {
        //Pregunto si es el protagonista/jugador, en caso de ser cierto se acomoda la barra de vida. Esto para evitar que todos los enemigos traten de acomodar la barra de vida.
        if (this.gameObject.name == "Heroe")
        {
            barraVida.SetearVida(life);
        }
    }

    public void SetearVida(int vida)
    {
        life = vida;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Obtengo el destructor para empezar a descontar la vida
        Destroyer myDestroyer = collision.gameObject.GetComponent<Destroyer>();

        //Pregunto si existe el destructor
        if (myDestroyer != null)
        {
            //Resto la vida del character
            life -= myDestroyer.damage;

            //Si la vida llega a cero se destruye el character
            if (life <= 0)
            {
                GameObject.Destroy(this.gameObject);
            }
        }
    }
}
