using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public int timerDuration=30 ;
    public TextMeshProUGUI timerText;
     public GameObject gamePanel;

    private float _currentTIme;
    void Start()
    {
        timerText.text = timerDuration.ToString();
        _currentTIme = timerDuration;
        gamePanel.SetActive(true);
    }

    void Update()
    {
        _currentTIme -= Time.deltaTime;
        if(_currentTIme <= 0)
        {
            _currentTIme = 0;

            Time.timeScale = 0f;
            
            // gamePanel.SetActive(true);
        }
         timerText.text = Mathf.CeilToInt(_currentTIme).ToString();

    }
}
