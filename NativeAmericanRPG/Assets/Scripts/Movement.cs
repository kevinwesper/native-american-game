using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float speed = 100;
    [SerializeField] private float jumpHeight = 10;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("vert");
            rb.AddForce(Vector3.forward * Input.GetAxis("Vertical") * speed, ForceMode.Acceleration);
        }
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("hor");
            rb.AddForce(Vector3.right * Input.GetAxis("Horizontal") * speed, ForceMode.Acceleration);
        }
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("jump");
            rb.AddForce(Vector3.up * jumpHeight * speed, ForceMode.Acceleration);
        }
    }
}
