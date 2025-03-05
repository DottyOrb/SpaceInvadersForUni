using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame() 
    {
        SceneManager.LoadScene("SpaceinDavers");
    }

    public void QuitGame() 
    {
        Application.Quit();
    }
}
