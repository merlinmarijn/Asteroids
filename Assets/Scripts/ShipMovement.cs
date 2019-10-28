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
    public int score;
    public Text HealthUI;
    public Text ScoreUI;
    public SaveNLoad saver;
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
        ScoreUI.text = "Score: "+score.ToString();
        if (Health <= 0)
        {
            saver.SaveScore();
            SceneManager.LoadScene(0);
        }
    }

    public void Points(int p)
    {
        score += p;
    }
}
