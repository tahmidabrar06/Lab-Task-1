using UnityEngine;
using UnityEngine.InputSystem;

public class FPSCam : MonoBehaviour
{
    public float sensitivity = 50f;
    public Transform playerTransform;

    private float xRotation = 0f;

    void Update()
    {
        Vector2 mouse = Mouse.current.delta.ReadValue();

        float mouseX = mouse.x * sensitivity * Time.deltaTime;
        float mouseY = mouse.y * sensitivity * Time.deltaTime;

        // Camera up/down
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Player turns left/right
        playerTransform.Rotate(Vector3.up * mouseX);
    }
}