using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity;
    private float xRotation = 0f;
    public GameObject player;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

   
    void Update()
    {
        followMouse();
    }
    
    void followMouse()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -30f, 26f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        player.transform.Rotate(Vector3.up * mouseX);


    }
    
}
