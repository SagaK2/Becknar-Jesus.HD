using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    //Jag gjorde två olika "menyer". Som man bara ser när man pausar eller dör. Jag fixar resten med slutscenen sen när Melvin gjort hindrena -Saga
    public GameObject endScreen;
    public GameObject pauseScreen;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Om man trycker på esc kommer man se en "pause meny"
            pauseScreen.SetActive(true);
        }
    }
}
