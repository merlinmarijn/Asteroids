using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidLaser : Bullet
{
    void Start()
    {
        Speed = 0.06f;
        damage = 1;
    }
}
