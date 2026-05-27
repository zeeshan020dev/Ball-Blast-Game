using UnityEngine;
using TMPro; // Essential for UI control

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // Drag ScoreText here in Inspector
    public TextMeshProUGUI healthText; // Drag HealthText here in Inspector
    public GameObject gameOverObject; // Drag GameOverText here

    private int score = 0;
    private int health = 3;

    void Start()
    {
        UpdateUI();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateUI();
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        UpdateUI();

        if (health <= 0)
        {
            GameOver();
        }
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        healthText.text = "Health: " + health;
    }

    void GameOver()
    {
        gameOverObject.SetActive(true); // Make the text appear
        Time.timeScale = 0;             // Freeze the game
    }
}