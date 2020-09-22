using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Joystick joystick;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    public Animator animator;
    

   
    void Update()
    {
        horizontalMove = joystick.Horizontal * runSpeed;
        if(Mathf.Abs(horizontalMove) > 0)
        {
            animator.SetFloat("Speed", Mathf.Abs(1));
        }
        else animator.SetFloat("Speed", Mathf.Abs(0));
        if (joystick.Vertical >= 0.4)
        {
            jump = true;
            animator.SetFloat("Jump", 1);
        }
        else
        {
            jump = false;
            animator.SetFloat("Jump", 0);

        }
    }
    public void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false , jump );
    }
}
