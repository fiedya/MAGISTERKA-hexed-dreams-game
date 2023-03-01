using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float mouseSensivity;
    
    public Transform player;

    float xRotation = 0f;
    float hardcodedSensivity = 250;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * hardcodedSensivity * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * hardcodedSensivity * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.localEulerAngles = Vector3.right * xRotation;

        player.Rotate(Vector3.up * mouseX);
    }
}
