using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;

    public float restartDelay = 1f;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("Level Complete!");
    }
    public void EndGame()
    {
        Debug.Log("Game Over");
        Invoke("ResetGame", restartDelay);
        // ResetGame();
    }

    void ResetGame()
    {
        Debug.Log("Game has been reset...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
