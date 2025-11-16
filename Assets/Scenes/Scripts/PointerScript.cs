using UnityEngine;

public class PointerScript : MonoBehaviour
{

    public Transform player;
    public Vector2 direction;
    private Camera mainCamera;
    void Start()
    {
        mainCamera=Camera.main;
    }

    void Update()
    {
        GetDirection();
        transform.position=(Vector2)player.position + direction*1.5f;
    }

    void GetDirection()
    {
        Vector2 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePosition - (Vector2)player.position).normalized;
    }
}
