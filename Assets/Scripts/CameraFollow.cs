using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform toFollow;

    [SerializeField]
    private float smoothTime = 3f;
    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector3(0, 0, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3(toFollow.position.x, toFollow.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velocity,smoothTime);
    }
}
