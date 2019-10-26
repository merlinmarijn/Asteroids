using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOE : MonoBehaviour
{
    public GameObject explosion;
    private void OnCollisionEnter2D(Collision2D col)
    {
        col.transform.GetComponentInParent<AsteroidManager>().TakeDamage(3, explosion);
    }
}
