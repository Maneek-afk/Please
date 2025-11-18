using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public PointerScript pointerScript;
    private Vector2 direction;
    public float gravityNumber;
    public float fartLoss = 7f;
    public float moveSpeed = 5f;

    public SoundManager soundManager;
    public FartManagerScrýpt fartManager;


    void Start()
    {
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 0;

        soundManager = FindFirstObjectByType<SoundManager>();
        pointerScript = FindFirstObjectByType<PointerScript>();
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = gravityNumber;
    }

    void Update()
    {
        direction = pointerScript.direction;

        if (Input.GetKeyDown(KeyCode.Space) && fartManager.maxFartMeter > 0)
        {
            PropelForce(direction);
            soundManager.PlayFartSound();
            fartManager.FartLoss(fartLoss);
            
            
        }

        if(Input.GetKey(KeyCode.A)){
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            Debug.Log("a pressed");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            Debug.Log("d pressed");
        }
    }

    void FixedUpdate()
    { 
        if (rb == null || direction == Vector2.zero)
            return;

        // rotation of player
        if (transform.position.y > -3f)
        {
            rb.MoveRotation(0f);
 
        }
      
        
    }

    void PropelForce(Vector2 direction){
        rb.AddForce(direction * 8f,ForceMode2D.Impulse);
    }

    void PopSOund(){
        if(soundManager != null){
            soundManager.PlayFartSound();
        }
    }
}
