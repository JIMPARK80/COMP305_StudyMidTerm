using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    public float parallaxFactor;

    public void Move(float delta)
    {
        Vector3 newPos = transform.position;
        newPos.x -= delta * parallaxFactor;

        transform.position = newPos;
    }
}
