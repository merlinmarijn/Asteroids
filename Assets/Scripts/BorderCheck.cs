using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCheck : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.y >= 5.3)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, -5.3f, gameObject.transform.position.z);
        }
        else if (gameObject.transform.position.y <= -5.3)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 5.3f, gameObject.transform.position.z);
        }
        if (gameObject.transform.position.x >= 5.3)
        {
            gameObject.transform.position = new Vector3(-5.3f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if (gameObject.transform.position.x <= -5.3)
        {
            gameObject.transform.position = new Vector3(5.3f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
}
