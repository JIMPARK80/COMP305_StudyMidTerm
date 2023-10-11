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
    private float jumpForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            Debug.Log("LeftArrow key pushed");

            // setting up animation for leftArrow
            animator.SetBool("isRunning", true);

            // player turning left
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            Debug.Log("RightArrow Key pushed");

            // setting up animation for rightArrow
            animator.SetBool("isRunning", true);

            // player turning right
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * jumpForce * Time.deltaTime;
            Debug.Log("UpArrow Key pushed");

            // setting up animator for jumping
            animator.SetBool("isJumping", true);
        }
        else
        {
            
            animator.SetBool("isRunning", false);
            animator.SetBool("isJumping", false);
        }       
    }
}