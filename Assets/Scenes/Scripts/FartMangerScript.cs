using UnityEngine;
using UnityEngine.UI;

public class FartMangerScript : MonoBehaviour
{
    public Image fartMeterFill;   
    public float maxFartMeter = 100f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(maxFartMeter <= 0)
        {
            maxFartMeter = 0;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            FartLoss(10f);
        }
    }

    public void FartLoss(float damage)
    {
        maxFartMeter -= damage;
        fartMeterFill.fillAmount = maxFartMeter / 100f;
    }

    public void FartRefli(float refil)
    {
        maxFartMeter += refil;
        maxFartMeter = Mathf.Clamp(maxFartMeter, 0, 100);
        fartMeterFill.fillAmount = maxFartMeter / 100f;
        }
}
