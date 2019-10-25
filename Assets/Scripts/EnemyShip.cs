using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public Rigidbody2D ship;
    public float AccelerationForce;
    public float RotationForce;
    public int Health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
}
