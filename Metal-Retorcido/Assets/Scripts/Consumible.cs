using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumible : MonoBehaviour
{
    public GameObject prefabBala;

    void Update()
    {
        //Genero un vector3 para decirle que gire en z para dar la ilusión de un objeto consumible
        Vector3 giro;
        giro.x = 0;
        giro.y = 0;
        giro.z = 10;
        transform.Rotate(giro);
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
