using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    protected GameObject Target;
    protected float Speed=1;
    protected int Health=3;
    private ShipMovement Player;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(Target.transform);
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<ShipMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetComponent<Rigidbody2D>().velocity = transform.forward * Speed;
        Destroy(gameObject, 10f);
    }
    public void TakeDamage(int dmg, GameObject Exp)
    {
        Health -= dmg;
        if (Health <= 0)
        {
            Player.Points(10);
            Instantiate(Exp, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "Player")
        {
            col.transform.GetComponent<ShipMovement>().Health -= 1;
            Destroy(gameObject);
        }
    }
}
