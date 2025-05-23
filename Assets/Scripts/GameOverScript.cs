using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public void GO_Restart() 
    {
        SceneManager.LoadScene("SpaceinDavers");
        ScoreManager.instance.ResetScore();
    }
    public void GO_Title() 
    {
        SceneManager.LoadScene("MainMenu");
        ScoreManager.instance.ResetScore();
    }
    public void GO_Quit() 
    { 
        Application.Quit();
    }
}
