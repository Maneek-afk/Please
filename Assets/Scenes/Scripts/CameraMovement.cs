
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;           
    public Vector3 offset = new Vector3(0, 0, -10);
    public float smoothSpeed = 10f;   

    void Start()
    {
        if (target == null)
        {
            var go = GameObject.FindWithTag("Player");
            if (go != null) target = go.transform;
        }
    }

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desired = new Vector3(
            target.position.x + offset.x,
            target.position.y + offset.y,
            offset.z
        );

        desired.y = Mathf.Max(desired.y, 0f);
        if (smoothSpeed <= 0f)
            transform.position = desired;
        else
            transform.position = Vector3.Lerp(transform.position, desired, smoothSpeed * Time.deltaTime);
    }
}
