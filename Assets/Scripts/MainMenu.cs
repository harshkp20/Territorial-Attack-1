using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  // Load next level
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit(); // Quit Game
    }
}