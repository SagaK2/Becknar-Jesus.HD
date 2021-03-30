<using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //Det här ska vara till scream button. Det här ska kunna skada arga människorna på banan. -Saga
    public Transform firePoint;
    //Det här är ljudvågorna som ska skada.
    public GameObject shockWave;
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(shockWave, firePoint.position, firePoint.rotation);
    }
}
