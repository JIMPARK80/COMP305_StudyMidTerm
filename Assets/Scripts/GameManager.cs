using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    [SerializeField]
    private TextMeshProUGUI scoreText;

    private int score = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AddScore()
    {
        score += 1;
        scoreText.text = "Score" + score;
    }
}
