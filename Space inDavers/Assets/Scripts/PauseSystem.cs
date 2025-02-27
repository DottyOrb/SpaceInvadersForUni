using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseSystem : MonoBehaviour
{
    public static bool isPaused;
    public GameObject PauseMenu;
    public GameObject GameOverMenu;

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
    public void GameOverToggle() 
    {
        isPaused = !isPaused;
        Time.timeScale = 0.0f;
        GameOverMenu.SetActive(true);
    }

    public void GO_Restart() 
    {
        isPaused = !isPaused;
        Time.timeScale = 1.0f;
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GO_Quit() 
    { 
        Application.Quit();
    }

}
