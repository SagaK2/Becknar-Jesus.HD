using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int health = 1;
    

    public void TakeDamadge()
    {
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        transform.position = new Vector2(25,0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Shockwave")
        {
            TakeDamadge();
        }
    }
}
