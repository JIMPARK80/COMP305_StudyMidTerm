using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}