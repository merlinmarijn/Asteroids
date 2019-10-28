using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOE : MonoBehaviour
{
    public GameObject explosion;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "Asteroid")
        {
        col.transform.GetComponentInParent<AsteroidManager>().TakeDamage(3, explosion);
        }
        else if (col.transform.tag == "Enemy")
        {
        col.transform.GetComponentInParent<EnemyShip>().TakeDamage(3, explosion);
        }
    }
}
