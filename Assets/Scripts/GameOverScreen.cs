using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Det här bestämer vad knapparna gör i game over scenen
public class GameOverScreen : MonoBehaviour
{
    //När man trycker på Restar knappen så laddas spelet scen in igen och spelet startar
    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    //När man trycker på main menu knappen så laddar man in menu scenen
    public void MenuButton()
    {
        SceneManager.LoadScene("meny scene");
    }
}