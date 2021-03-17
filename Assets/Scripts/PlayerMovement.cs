using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; //Hastighet av hoppet /Theo
    public float jumpforce; //Hur ögt man hoppar
    public float moveinput; 
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))   //Om du trycket up arrow = Hoppa /Theo
        {
            rb.velocity = Vector2.up * jumpforce;
        }
    }
}
