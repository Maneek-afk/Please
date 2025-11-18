using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public PointerScript pointerScript;
    private Vector2 direction;

    public SoundManager soundManager;


    void Start()
    {
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 0;

        soundManager = FindFirstObjectByType<SoundManager>();
        pointerScript = FindFirstObjectByType<PointerScript>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction = pointerScript.direction;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PropelForce(direction);
            PopSOund();
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
            // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            // rb.MoveRotation(angle);
        }
        // else{
        // //     
        // // }
        
    }

    void PropelForce(Vector2 direction){
        rb.AddForce(direction * 10f,ForceMode2D.Impulse);
    }

    void PopSOund(){
        if(soundManager != null){
            soundManager.PlayFartSound();
        }
    }
}
