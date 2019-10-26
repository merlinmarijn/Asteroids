using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject Explosion;
    protected float Speed = 0.05f;
    protected int damage = 3;
    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        transform.position += transform.up * Speed;
        Destroy(gameObject, 10f);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag=="Asteroid")
        {
            col.transform.GetComponentInParent<AsteroidManager>().TakeDamage(damage,Explosion);
            Destroy(gameObject);
        } if (col.transform.tag == "Enemy")
        {
            col.transform.GetComponentInParent<EnemyShip>().TakeDamage(damage, Explosion);
            Destroy(gameObject);
        }
    }
}
