using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public Rigidbody2D ship;
    protected float AccelerationForce= 0.5f;
    protected float RotationForce= 0.1f;
    protected int Health=3;

    // Update is called once per frame
    void Update()
    {
        Vector2 target = GameObject.FindGameObjectWithTag("Player").transform.position - transform.position;
        Vector3 cross = Vector3.Cross(target, transform.up);
        float sign = Mathf.Sign(cross.z);
        float angle = Vector2.Angle(target, transform.up);
        angle *= sign;
        ship.AddTorque(-sign * RotationForce);
        ship.AddForce(transform.up * AccelerationForce);
    }

    public void TakeDamage(int dmg, GameObject exp)
    {
        Health -= dmg;
        if (Health <= 0)
        {
            Instantiate(exp, transform.position, Quaternion.identity);
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
