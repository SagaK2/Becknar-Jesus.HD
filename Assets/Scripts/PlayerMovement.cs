using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; //Hastighet av hoppet /Theo
    public float jumpforce; //Hur högt man hoppar
    public float moveinput; 
    public Rigidbody2D rb;
    //gör så att gubben kan röra på sig (hoppa) när man trycker på up arrow -Saga
    public Animator animator;
    //Jag gjorde två olika "menyer". Som man bara ser när man pausar eller dör. Jag fixar resten med slutscenen sen när Melvin gjort hindrena -Saga
    public GameObject endScreen;
    public GameObject pauseScreen;
   

    //Det här ska vara till scream button. Det här ska kunna förgöra saker på banan -Saga
    public Transform firePoint;
    //Det här är ljudvågorna som ska skada.
    public GameObject shockWave;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        //test -Saga
        animator.SetBool("run", true);
        animator.SetBool("jump", false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))   //Om du trycket up arrow = Hoppa /Theo 
        {
            rb.velocity = Vector2.up * jumpforce;
            animator.SetBool("jump", true);
            animator.SetBool("run", false);
        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            //Om man trycker på esc kommer man se en "pause meny"
            pauseScreen.SetActive(!pauseScreen.activeSelf);
            animator.SetBool("standing", true);
            animator.SetBool("run", false);
        }
        if(animator.GetBool("standing") == false)
        {
            animator.SetBool("jump", false);
            animator.SetBool("run", true);
        }

        if (!pauseScreen.activeSelf)
        {
            animator.SetBool("standing", false);
            animator.SetBool("run", true);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Sream button -Saga
            animator.SetBool("scream", true);
            animator.SetBool("run", false);
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(shockWave, firePoint.position, firePoint.rotation);
    }

    //När gubben kommer ner på marken efter att ha hoppat slutar den att hoppa. Hann inte jobba mer med det här. Kan göra det sen -Saga
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            animator.SetBool("jump", false);
            animator.SetBool("run", true);
            print("Ground2");
        }
    }
}
