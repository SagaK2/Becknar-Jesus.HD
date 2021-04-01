using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockWave : MonoBehaviour
{
    // Gör så att ljudet kan röra sig framåt (Så att den kan förgöra) -Saga
    public float speed = 20f;
    public int damage = 1;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ShDestroy")
        {
            transform.position = new Vector2(-7.22f, 0);
            speed = 0;
        }
    }
}
