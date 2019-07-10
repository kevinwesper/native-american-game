using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;

    [SerializeField] private float jumpHeight = 10;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("vert");
            controller.Move(Vector3.forward * Input.GetAxis("Vertical"));
        }
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("hor");
            controller.Move(Vector3.right * Input.GetAxis("Horizontal"));
        }
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            Debug.Log("jump");
            controller.Move(Vector3.up * jumpHeight);
        }
        if (!controller.isGrounded)
        {
            Debug.Log("fall");
            controller.Move(-Vector3.up);
        }
    }
}
