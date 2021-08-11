using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public bool brakeMouse = true; 
    public float sensibility = 2.0f; 

    private float mouseX = 0.0f, mouseY = 0.0f; 

    void Start()
    {
        if (!brakeMouse)
        {
            return;
        }

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked; 
    }


    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * sensibility; 
        mouseY -= Input.GetAxis("Mouse Y") * sensibility; 

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
}
