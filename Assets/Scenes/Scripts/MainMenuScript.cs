using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1); // Assuming the main game scene is at index 1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
