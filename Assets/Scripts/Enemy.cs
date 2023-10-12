using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
            Debug.Log("Ground");
            GameManager.instance.AddScore();
        }
        else if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Player");
        }
    }
}