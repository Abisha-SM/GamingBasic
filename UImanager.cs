using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public static UImanager instance;
    public void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateCoins()
    {
        score++;
        scoreText.text = "Score:" + score;
    }
}
