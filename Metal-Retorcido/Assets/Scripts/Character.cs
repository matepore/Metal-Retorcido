using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public GameObject prefabBala;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Vector3 direction)
    {
        rb.velocity = direction * speed;
        rb.transform.up += direction * rotationSpeed;

        //Tenía pensado usar addtorque para hacer el giro mas natural y que no se "teletransporte" al hacer un giro, pero me es imposible con lo que conozco.
    }

    public void Fire()
    {
        GameObject miBala = GameObject.Instantiate(prefabBala);
        miBala.transform.position = transform.position;
        miBala.transform.up = transform.up;
        miBala.layer = gameObject.layer;
    }
}
