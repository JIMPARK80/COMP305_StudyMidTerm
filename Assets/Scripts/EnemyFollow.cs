using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private Transform targetTransform;

    [SerializeField]
    private float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        targetTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the target position but only use the X coordinate
        Vector3 targetPosition = new Vector3(targetTransform.position.x, transform.position.y, transform.position.z);

        // Calculate the direction to move (only along the X-axis)
        Vector3 moveDirection = (targetPosition - transform.position).normalized;

        // Update the position of the enemy (only along the X-axis)
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

    }
}