using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float fireRate;
    private float coolDown;
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
        coolDown -= Time.deltaTime;
        coolDown = Mathf.Clamp(coolDown, 0, fireRate);
    }

    public void Move(Vector3 direction)
    {
        rb.velocity = direction * speed;
        rb.transform.up += direction * rotationSpeed;
    }

    public void Fire()
    {
        if (coolDown <= 0)
        {
            GameObject miBala = GameObject.Instantiate(prefabBala);
            miBala.transform.position = transform.position;
            miBala.transform.up = transform.up;
            miBala.layer = gameObject.layer;

            coolDown = fireRate;
        }
    }
}
