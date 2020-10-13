using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Text playerDisplay;
    public Button gameButton;

    private void Start()
    {
        gameButton.interactable = false;

        if (DBManager.LoggedIn)
        {
            playerDisplay.text = "Player:" + DBManager.username;
            gameButton.interactable = true;
        }
    }

    public void GoToResgister()
      {
        SceneManager.LoadScene("RegisterMenuScene");
    }
    public void GoToLogin()
    {
        SceneManager.LoadScene("LoginMenuScene");
    }
    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
    }
}
