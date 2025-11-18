using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Debug.Log("Triggered with: " + other.name);
        if (collision.tag=="Player")
        {
            Debug.Log("Player touched the object. Game Over!");
            SceneManager.LoadScene(2);
        }
    }
}
