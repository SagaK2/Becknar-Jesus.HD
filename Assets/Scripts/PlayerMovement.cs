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
    //Man kan bara hoppa ett visst par gånger så att man inte kan flyga
    int currentJump = 0;
    int maxJump = 3;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //test -Saga
        animator.SetBool("run", true);
        animator.SetBool("jump", false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && currentJump <= maxJump)   //Om du trycket up arrow = Hoppa /Theo - Och om man inte hoppat max antalet -Saga
        {
            rb.velocity = Vector2.up * jumpforce;
            animator.SetBool("jump", true);
            animator.SetBool("run", false);
            currentJump++; //Den räknar varje gång man hoppar tills max antalet -Saga
            print("Jump");
        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            //Om man trycker på esc kommer man se en "pause meny"
            pauseScreen.SetActive(!pauseScreen.activeSelf);
            animator.SetBool("standing", true);
            animator.SetBool("run", false);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Sream button -Saga
            animator.SetBool("scream", true);
            animator.SetBool("run", false);
        }

        if(currentJump == 0 && animator.GetBool("standing") == false)
        {
            animator.SetBool("jump", false);
            animator.SetBool("run", true);
        }

        if (!pauseScreen.activeSelf)
        {
            animator.SetBool("standing", false);
            animator.SetBool("run", true);
        }
    }
    //När gubben kommer ner på marken efter att ha hoppat slutar den att hoppa. Hann inte jobba mer med det här. Kan göra det sen -Saga
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            animator.SetBool("jump", false);
            animator.SetBool("run", true);
            currentJump = 0;
            print("Ground2");
            //Antingen stannar det vid att run är true och jump blir också det eller att jump är true och stannar vid det.
        }
    }
}
