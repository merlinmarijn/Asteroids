using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public float Speed;
    public float Lifespan;
    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        transform.position += transform.up * Speed;
        Lifespan -= Time.deltaTime;
        if (Lifespan < 0f)
        {
            Destroy(gameObject);
        }
    }
}
