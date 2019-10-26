using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject[] Explosion;
    public GameObject DestroyBullet;
    private int Health = 3;

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "Player")
        {
            if (transform.tag == "Enemy")
            {
                col.transform.GetComponent<ShipMovement>().Health -= 1;
                Destroy(DestroyBullet);
            } else
            {
                col.transform.GetComponent<ShipMovement>().Health -= 1;
                Destroy(DestroyBullet);
            }
        } else if (col.transform.tag == "Bullet")
        {
            Destroyed(0,true, col.transform.gameObject);
        } else if (col.transform.tag == "Rocket")
        {
            Destroyed(1,true, col.transform.gameObject);
        } else if (col.transform.tag == "Explosion")
        {
            Destroyed(0,true, col.transform.gameObject);
        } else if (col.transform.tag == "laser")
        {
            Destroy(col.gameObject);
            Health--;
            if (Health <= 0)
            {
                Destroyed(0,true,col.transform.gameObject);
            }
        }
    }

    void Destroyed(int ExplodeMode, bool instakill, GameObject Bullet)
    {
        if (Bullet.transform.tag != "Explosion")
        {
            Destroy(Bullet);
            Instantiate(Explosion[ExplodeMode], transform.position, Quaternion.identity);
        }
        if(instakill == true)
        {
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
