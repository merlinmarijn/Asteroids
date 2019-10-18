using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunManager : MonoBehaviour
{
    //The Weapon prefabs used for instantiating
    public GameObject[] Bullet;
    //Timer used to create a clock for shooting
    private float RTimer;
    //Weapon 1: laser, Weapons 2: Rocket, etc....
    private int WeaponSlots=1;
    //Shoot Speed of weapons explained above this
    private float[] ShootSpeed = {0.5f, 2};
    //Current Weapon Equiped
    private int WeaponPos = 0;
    //Object to spawn the bullets on
    public GameObject BulletSpawner;
    //Current Weapon UI
    public Text WeaponUI;

    void Update()
    {
        RTimer -= Time.deltaTime;
        if (RTimer <= 0)
        {
            if (Input.GetKey(KeyCode.F))
            {
                Instantiate(Bullet[WeaponPos], BulletSpawner.transform.position, BulletSpawner.transform.rotation);
                RTimer = ShootSpeed[WeaponPos];
            }
        }
        //IF "G" Pressed Swap weapons
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (WeaponPos >= WeaponSlots)
            {
                WeaponPos = 0;
            } else
            {
                WeaponPos++;
            }
        }
        if (WeaponPos == 0)
        {
            WeaponUI.text = "Weapon: Lazer";
        } else if (WeaponPos == 1)
        {
            WeaponUI.text = "Weapon: Rocket";
        }
    }
}
