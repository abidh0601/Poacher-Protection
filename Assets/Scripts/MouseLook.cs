#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Animations;

public class MouseLook : MonoBehaviour
{
    private Player_Input player_Input;
    [SerializeField] private float mouseSensitivity = 10f;

    [SerializeField] private Transform playerBody;
    private Quaternion targetRotation;

    float xRotation = 0f;
    float yRotation = 0f;

    private void Awake()
    {
        player_Input = new Player_Input();
    }

    private void OnEnable()
    {
        player_Input.Enable();
    }

    private void OnDisable()
    {
        player_Input.Disable();
    }

 
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {


        //Debug.Log(angle);
        //if (angle > 15f)
        //{
        //    playerBody.rotation = Quaternion.RotateTowards(playerBody.rotation, Camera.main.transform.rotation, 3f);
        //}
        

        float mouseX = player_Input.Player.xLook.ReadValue<float>() * mouseSensitivity * Time.deltaTime;
        float mouseY = player_Input.Player.yLook.ReadValue<float>() * mouseSensitivity * Time.deltaTime;

        //Debug.Log("Mouse x: " + mouseX + " mouseY: " + mouseY);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        yRotation += mouseX;
           
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

    }
}

#endif