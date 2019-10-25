using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawnManager : MonoBehaviour
{
    public GameObject[] Asteroid;
    public GameObject[] SpawnPoints;
    public float Spawnrate;
    public int Spawncount;
    private float Timer = 1;

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            int randomnum = Random.Range(0, SpawnPoints.Length - 1);
            if (Random.Range(0, 10) != 5)
            {
                Instantiate(Asteroid[0], SpawnPoints[randomnum].transform.position, transform.rotation);
            } else
            {
                Instantiate(Asteroid[1], SpawnPoints[randomnum].transform.position, transform.rotation);
            }
            Timer = Spawnrate;
        }
    }
}
