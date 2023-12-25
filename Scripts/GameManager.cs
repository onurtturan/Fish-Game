using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore ()
    {
        score++;
        ScoreText.text = "SCORE: "+score.ToString();
    }

    public void DecreaseScore()
    {
        score--;
        ScoreText.text = "SCORE: "+score.ToString();

    }
}
