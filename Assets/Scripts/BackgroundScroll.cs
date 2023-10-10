using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 6f;

    [SerializeField]
    private float posX;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= -posX)
        {
            transform.position = new Vector3(posX, 0, 0);
        }
    }
}
