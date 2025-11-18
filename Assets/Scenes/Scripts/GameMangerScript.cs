using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMangerScript : MonoBehaviour
{
    public GameObject panelObject;
    public void PauseGame()
    {
        Time.timeScale = 0f; // freezes gameplay
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // resumes gameplay
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        panelObject.SetActive(false);   

    }

    public void QuitGame()
    {
        Application.Quit();
        // Note: Quit only works in a built game, not in the editor
    }
}
