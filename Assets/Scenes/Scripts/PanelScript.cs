using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanelScript : MonoBehaviour
{
    
    public Button button1;
    public Button button2;
    public TextMeshProUGUI gameOverText;

    void Start()
    {
        RectTransform rt = GetComponent<RectTransform>();

        rt.anchorMin = new Vector2(0.25f, 0.25f);
        rt.anchorMax = new Vector2(0.75f, 0.75f);
        rt.offsetMin = Vector2.zero;
        rt.offsetMax = Vector2.zero;

        Image img = GetComponent<Image>();
        img.color = new Color(0f, 0f, 0f, 0.5f);

        // GAME OVER TEXT
        RectTransform gotRT = gameOverText.GetComponent<RectTransform>();
        gotRT.anchorMin = new Vector2(0.2f, 0.75f);
        gotRT.anchorMax = new Vector2(0.8f, 0.90f);
        gotRT.offsetMin = Vector2.zero;
        gotRT.offsetMax = Vector2.zero;

        gameOverText.text = "Game Over";
        gameOverText.alignment = TextAlignmentOptions.Center;
        gameOverText.fontSize = 30;

        // BUTTON 1 (Restart)
        RectTransform b1rt = button1.GetComponent<RectTransform>();
        b1rt.anchorMin = new Vector2(0.2f, 0.55f);
        b1rt.anchorMax = new Vector2(0.8f, 0.67f);
        b1rt.offsetMin = Vector2.zero;
        b1rt.offsetMax = Vector2.zero;

        button1.GetComponentInChildren<TextMeshProUGUI>().text = "Restart";

        // BUTTON 2 (End)
        RectTransform b2rt = button2.GetComponent<RectTransform>();
        b2rt.anchorMin = new Vector2(0.2f, 0.30f);
        b2rt.anchorMax = new Vector2(0.8f, 0.42f);
        b2rt.offsetMin = Vector2.zero;
        b2rt.offsetMax = Vector2.zero;

        button2.GetComponentInChildren<TextMeshProUGUI>().text = "End";
    }
}
