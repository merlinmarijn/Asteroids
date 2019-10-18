using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject[] Explosion;

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "Player")
        {
            Debug.Log("Player has been hit");
            col.transform.GetComponent<ShipMovement>().Health -= 1;
            Destroy(gameObject);
        } else if (col.transform.tag == "Bullet")
        {
            Debug.Log("Asteroid has been hit by bullet and has been destroyed");
            Instantiate(Explosion[0],transform.position,Quaternion.identity);
            Destroy(col.gameObject);
            Destroy(gameObject.transform.parent.gameObject);
        } else if (col.transform.tag == "Rocket")
        {
            Destroy(col.gameObject);
            Instantiate(Explosion[1], transform.position, Quaternion.identity);
        } else if (col.transform.tag == "Explosion")
        {
            Instantiate(Explosion[0], transform.position, Quaternion.identity);
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
