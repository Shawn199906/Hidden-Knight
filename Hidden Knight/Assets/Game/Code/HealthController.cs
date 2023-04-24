using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public float playerHealth;
    [SerializeField] private Text healthText;

    private void Start()
    {
        updateHealth();
    }
    public void updateHealth()
    {
        healthText.text = playerHealth.ToString("0");
        if (playerHealth<=0)
        {
            SceneManager.LoadScene(sceneName: "GameOver");
            ScoreSystem.PlayerScore = 0;
        }
    }
}
