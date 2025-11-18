using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FartManagerScrıpt : MonoBehaviour
{
    public Image fartMeterFill;
    public float maxFartMeter = 100f;




    public void FartLoss(float damage)
    {
        if (maxFartMeter > 0)
        {
            maxFartMeter -= damage;

            if (maxFartMeter <= 0)
            {
                SceneManager.LoadScene(2);
            }

            fartMeterFill.fillAmount = maxFartMeter / 100f;
        }
    }

    public void FartRefli(float refil)
    {
        if (maxFartMeter >= 100)
        {
            maxFartMeter = 100;
            maxFartMeter += refil;
            maxFartMeter = Mathf.Clamp(maxFartMeter, 0, 100);
            fartMeterFill.fillAmount = maxFartMeter / 100f;
        }

        
    }
}
