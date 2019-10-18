using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTimer : MonoBehaviour
{
    public float Timer;
    private float RTimer;
    private void Start()
    {
        RTimer = Timer;
    }

    // Update is called once per frame
    void Update()
    {
        RTimer -= Time.deltaTime;
        if (RTimer <= 0)
        {
            Destroy(gameObject);
            RTimer = Timer;
        }
    }
}
