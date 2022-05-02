using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void ReplayGame ()
    {
        int firstLevelIndex = 1;
        SceneManager.LoadScene(firstLevelIndex);
    }

    public void MainMenu()
    {
        int mainMenuIndex = 0;
        SceneManager.LoadScene(mainMenuIndex);
    }
    public void QuitGame()
    {
        Debug.Log("Quiting game...");
        Application.Quit();
    }

}
