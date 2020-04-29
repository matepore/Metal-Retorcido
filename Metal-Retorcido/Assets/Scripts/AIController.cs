using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    Character auto;
    private GameObject enemigo;
    int indice;

    // Start is called before the first frame update
    void Start()
    {
        auto = GetComponent<Character>();

        //Creo un array de autos
        GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Auto");

        //Creo un indice random para que el personaje elija un enemigo al azar
        indice = Random.Range(0, enemigos.Length);

        //Igualo el objeto recibido a una variable
        enemigo = enemigos[indice];
    }

    // Update is called once per frame
    void Update()
    {
        //Pregunto si el enemigo elegido existe, esto sirve para que cuando tu enemigo muera no lo siga usando
        if (enemigo)
        {

            //Verifico que el enemigo no seas vos
            if(enemigo != this.gameObject)
            {
                //Establezco una variable para calcular la distancia entre el objetivo y este personaje.
                float distancia;
                distancia = Vector3.Distance(enemigo.transform.position, transform.position);

                //Pregunto por si esa distancia está dentro de un rango especifico o no. Si esta dentro, significa que el personaje puede ver su objetivo.
                if (distancia < 6.5f)
                {
                    //Veo a mi objetivo
                    transform.up = enemigo.transform.position - transform.position;
                    auto.Fire();
                }
                else
                {
                    //No veo a mi objetivo
                    transform.up = enemigo.transform.position - transform.position;
                    auto.Move(transform.up);
                }
            }
            //En caso de que el enemigo seas vos, va a entrar a este else y va a cambiar la variable enemigo para que sea nula y busque otro
            else
            {
                enemigo = null;
            }
            
        }
        else
        {
            GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Auto");
            indice = Random.Range(0, enemigos.Length);
            enemigo = enemigos[indice];
        }
    }
}
