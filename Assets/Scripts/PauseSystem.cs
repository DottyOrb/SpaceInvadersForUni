using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseSystem : MonoBehaviour
{
    public static bool isPaused;
    public GameObject PauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            PauseToggle();
        }
    }

    void PauseToggle()
    {
        if (isPaused)
        {
            Time.timeScale = 0.0f;
            PauseMenu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1.0f;
            PauseMenu.SetActive(false);
        }
    }

    public void ResumeButton() 
    {
        isPaused = !isPaused;
        PauseToggle();
    }
    
    public void RestartButton() 
    {
        isPaused = !isPaused;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void titleButton() 
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitButton() 
    { 
        Application.Quit();
    }

}
