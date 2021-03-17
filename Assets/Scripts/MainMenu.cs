using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    //-Saga
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public void Back()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
    public void PlayGame()
    {
        //Så att man kan loada fler scener än en specifik scen tex scen 1
        SceneManager.LoadScene(1);
        if (SceneManager.sceneCount == 1)
        {
            SceneManager.LoadScene(0);
        }
    }
    public void QuitGame()
    {
        //Avslutar spelet när den har "Byggts då"
        Application.Quit();

    }
}
