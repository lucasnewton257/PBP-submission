﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool isJumping = false;
    bool isCrouching = false;
        // Update is called once per frame
	void Update () {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump"))
            isJumping = true;
        
        if (Input.GetButtonDown("Crouch"))
        {
            isCrouching = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            isCrouching = false;
        }
	}
    public void OnLanding()
    {
        
    }
    private void FixedUpdate()
    {
        //Move the character
        controller.Move(horizontalMove * Time.fixedDeltaTime, isCrouching, isJumping);
        isJumping = false;
       
    }
}
