using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    public int life;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroyer myDestroyer = collision.gameObject.GetComponent<Destroyer>();
        if (myDestroyer != null)
        {
            life -= myDestroyer.damage;
            if (life <= 0)
            {
                GameObject.Destroy(this.gameObject);
            }
        }
    }
}
