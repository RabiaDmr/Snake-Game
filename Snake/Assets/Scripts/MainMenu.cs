using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    

    public void OptionEasy()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("Easy");

    }

   
    public void OptionHard()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("Hard");
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();

    }
}
