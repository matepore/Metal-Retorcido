using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumible : MonoBehaviour
{
    public GameObject prefabBala;
    Rigidbody2D rb;

    void Update()
    {
        rb = GetComponent<Rigidbody2D>();

        //Genero una rotación en el objeto para simular los consumibles del twisted metal
        rb.rotation += -10;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Pregunto si el objeto con el que colisiona tiene el tag auto, si no lo es no me interesa
        if(collision.gameObject.tag == "Auto")
        {
            //Verifico que el consumible sea una bala para que haga su comportamiento
            if(this.gameObject.tag == "ConsumibleBala")
            {
                collision.gameObject.GetComponent<Character>().prefabBala = prefabBala;
                GameObject.Destroy(this.gameObject);
            }
            //Acá verifico si es un consumible de curacion y hago que cumpla su comportamiento
            else if(this.gameObject.tag == "ConsumibleCuracion")
            {
                int life = collision.gameObject.GetComponent<Destroyable>().life;
                life += 150;
                if(life > 300)
                {
                    life = 300;
                }
                GameObject.Destroy(this.gameObject);
            }
        }
    }
}
