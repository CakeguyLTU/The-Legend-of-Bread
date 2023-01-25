using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public CharacterController controller;
    private Vector3 direction;
    public float speed = 8;
    public Animator animator;
    public float jumpForce = 10;
    public float gravity = -20;
    public Transform groundCheck;
    public LayerMask groundLayer;
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        direction.x = hInput * speed;
        bool isGrounded = Physics.CheckSphere(groundCheck.position, 0.2f, groundLayer);
        direction.y += gravity * Time.deltaTime;
        if(isGrounded)
        {

            if (Input.GetButtonDown("Jump"))
            {
                 direction.y = jumpForce;
            }

            if(Input.GetKeyDown(KeyCode.F))
            {
                animator.SetTrigger("fireBallAttack");
            }
        }
 
        controller.Move(direction * Time.deltaTime);
    }
}