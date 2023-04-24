using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtoms : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(sceneName:"Game");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
