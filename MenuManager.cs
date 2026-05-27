using UnityEngine;
using UnityEngine.SceneManagement; // Needed for Restarting

public class MenuManager : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject pauseMenu;
    private bool isPaused = false;
    public GameObject pauseButton; // NEW: Drag your PauseButton here
    public GameObject hudParent; // Drag an object containing Score and Health here

    void Start()
    {
        // Start the game in a "Paused" state so the menu shows
        Time.timeScale = 0;
        startMenu.SetActive(true);
        pauseMenu.SetActive(false);
        // Hide the HUD at the very beginning
        if (hudParent != null) hudParent.SetActive(false);
    }

    void Update()
    {
        // Check for Escape key to pause
        if (Input.GetKeyDown(KeyCode.Escape) && !startMenu.activeSelf)
        {
            if (isPaused) ResumeGame();
            else PauseGame();
        }
    }

    public void StartGame()
    {
        startMenu.SetActive(false);
        pauseButton.SetActive(true); // Show button when game starts
        // Show the HUD when the game starts
        if (hudParent != null) hudParent.SetActive(true);
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        isPaused = true;
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false); // Hide button while paused
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true); // Show button when resuming
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        // This reloads the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitToMain()
    {
        // Simply reloads the scene which defaults back to the Start Menu
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Exited"); // Only visible in build
    }
}