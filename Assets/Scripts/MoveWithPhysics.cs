using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithPhysics : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 movement = Vector3.zero;
    [SerializeField] float moveForce = 2f;
    [SerializeField] float jumpForce = 5f;

    private bool isGrounded = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

    }
    private void FixedUpdate()
    {
        rb.AddForce(movement * moveForce);
    }
    void Jump()
    {
        rb.velocity = Vector3.up * jumpForce;
    }
}