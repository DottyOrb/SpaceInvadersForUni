using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public void ContinueButton()
    {
        SceneManager.LoadScene("SpaceinDavers");
    }
    public void TitleButton()
    {
        SceneManager.LoadScene("MainMenu");
        ScoreManager.instance.ResetScore();
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
