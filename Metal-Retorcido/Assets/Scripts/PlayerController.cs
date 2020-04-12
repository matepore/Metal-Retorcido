using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Character auto;

    // Start is called before the first frame update
    void Start()
    {
        auto = GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion;
        direccion.x = Input.GetAxis("Horizontal");
        direccion.y = Input.GetAxis("Vertical");
        direccion.z = 0;

        auto.Move(direccion);

        //La camara persigue al personaje.
        Camera.main.transform.position = this.transform.position + Vector3.back * 10;
    }
}
