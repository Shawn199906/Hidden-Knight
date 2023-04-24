using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameButtoms : MonoBehaviour
{
    // Start is called before the first frame update
    public void BacktoMainMenu()
    {
        SceneManager.LoadScene(sceneName:"MainMenu");
        ScoreSystem.PlayerScore = 0;
    }
}
