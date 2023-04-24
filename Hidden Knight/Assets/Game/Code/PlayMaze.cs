using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMaze : MonoBehaviour
{
    public void PlayGameMaze()
    {
        SceneManager.LoadScene(sceneName: "Maze");
    }
}
