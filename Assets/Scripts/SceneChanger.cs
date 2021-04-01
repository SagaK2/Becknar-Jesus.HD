using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{ //Den här koden ska göra så att när playern colliderar med ett hinder så skickas man till game over screenen-Melvin
    public string newscene;
    //när den triggar det som koden är lagd på så kan man ladda en ny scen
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(newscene, LoadSceneMode.Single);
    }
}
