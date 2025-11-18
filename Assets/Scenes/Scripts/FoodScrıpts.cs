using UnityEngine;

public class FoodScrıpts : MonoBehaviour
{

    public FartManagerScrıpt fartManager;
    public SoundManager soundManager;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

      
        if (collision.tag == "Player")
        {
            Debug.Log("Eatıng pizza");
            fartManager.maxFartMeter = 100f;
            Destroy(gameObject);
            soundManager.PlayEatSound();

        }
    }
}
