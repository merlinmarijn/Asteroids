using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenresolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(720, 576, true);
    }
}
