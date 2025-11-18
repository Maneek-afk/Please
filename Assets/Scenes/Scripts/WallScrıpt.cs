using UnityEngine;
using UnityEngine.SceneManagement;



public class WallScrıpt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Debug.Log("Triggered with: " + other.name);
        if (collision.tag == "Player")
        {
            Debug.Log("Player touched the wall. Game Over!");

            
            SceneManager.LoadScene(2);
        }
    }
}
