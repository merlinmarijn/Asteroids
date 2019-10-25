using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public Rigidbody2D ship;
    public float AccelerationForce = 10f;
    public float RotationForce = 3f;
    public int Health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ship.AddTorque(rotation * -RotationForce);
        ship.AddForce(transform.up * AccelerationForce);
    }
}
