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
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
