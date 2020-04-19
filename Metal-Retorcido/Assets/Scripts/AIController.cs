using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    Character auto;
    private GameObject enemigo;

    // Start is called before the first frame update
    void Start()
    {
        auto = GetComponent<Character>();
        enemigo = GameObject.Find("Heroe");
    }

    // Update is called once per frame
    void Update()
    {
        if (enemigo)
        {
            float distancia;

            distancia = Vector3.Distance(enemigo.transform.position, transform.position);
            if (distancia < 9.5f)
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
    }
}
