using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShipMovement : MonoBehaviour
{
    public Rigidbody2D ship;
    public float AccelerationForce = 10f;
    public float RotationForce = 3f;
    public int Health;
    public Text HealthUI;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float rotation = Input.GetAxis("Horizontal");
        float acceleration = Input.GetAxis("Vertical");
        ship.AddTorque(rotation * -RotationForce);
        ship.AddForce(transform.up * acceleration * AccelerationForce);
        HealthUI.text = "Health: " + Health;
        if (Health <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
