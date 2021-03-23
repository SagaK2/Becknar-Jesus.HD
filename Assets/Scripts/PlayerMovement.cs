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
            //verkar inte fungera, vet inte varför -Saga
            animator.SetBool("jump", true);
        }else if(Input.GetKeyDown(KeyCode.Escape))
        {
            //Om man trycker på esc kommer man se en "pause meny"
            pauseScreen.SetActive(true);
        }

    }
    //När gubben kommer ner på marken efter att ha hoppat slutar den att hoppa. Hann inte jobba mer med det här. Kan göra det sen -Saga
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            animator.SetBool("jump", false);
        }
    }
}
