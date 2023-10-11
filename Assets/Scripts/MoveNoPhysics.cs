using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNoPhysics : MonoBehaviour
{

    // add Animation
    private Animator animator;

    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private float jumpForce = 5f;
    private Rigidbody2D rb;

    private bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            Debug.Log("LeftArrow key pushed");

            // animation set up
            animator.SetBool("isRunning", true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            Debug.Log("RightArrow Key pushed");
            animator.SetBool("isRunning", true);
        }
        else if (Input.GetKey(KeyCode.UpArrow) && isGrounded == true)
        {
            Jump();
            Debug.Log("UpArrow Key pushed");
        }
        else
        {
            // animator set up
            animator.SetBool("isRunning", false);
            return;
        }
        
        
    }

    private void Jump()
    {
        transform.position += Vector3.up * jumpForce * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}