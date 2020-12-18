using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 500f;
    float xRotation = 0f;
    float yRotation = 0f;

    public Transform playerBody;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        //yRotation += mouseX;

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        //transform.localRotation = Quaternion.Euler(yRotation, 0, 0);
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
