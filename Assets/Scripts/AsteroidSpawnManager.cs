using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawnManager : MonoBehaviour
{
    public GameObject Asteroid;
    public GameObject[] SpawnPoints;
    public float Spawnrate;
    public int Spawncount;
    private float Timer = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            int randomnum = Random.Range(0, SpawnPoints.Length - 1);
            Instantiate(Asteroid, SpawnPoints[randomnum].transform.position, transform.rotation);
            Timer = Spawnrate;
        }
    }
}
