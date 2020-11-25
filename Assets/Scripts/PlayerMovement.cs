using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Player_Input player_Input;
    public int playerSpeed = 5;

    //Gravity
    //Vector3 velocity;
    //[SerializeField] private float gravity = -9.81f;

    //Ground check
    //[SerializeField] private Transform groundCheck;
    //[SerializeField] private float groundDistance = 0.4f;
    //[SerializeField] private LayerMask groundMask;
    //bool isGrounded;



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

    // Update is called once per frame
    void Update()
    {
        {//isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        //if(isGrounded && velocity.y < 0)
        //{
        //    velocity.y = -0.2f;
        //}

        //float z = Input.GetAxis("Vertical");

        //if (Input.GetButtonDown("Fire1"))
        //{
        //    z = 1.0f;
        //}

        //Debug.Log(x);
        //Vector3 move =  transform.forward* x;

        ////Debug.Log(move);

        //character.Move(move * playerSpeed * Time.deltaTime);



        //character.Move(velocity);
        }
        float x = player_Input.Player.move.ReadValue<float>();
        //Debug.Log(x);

            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime * x;
        


    } 
}
