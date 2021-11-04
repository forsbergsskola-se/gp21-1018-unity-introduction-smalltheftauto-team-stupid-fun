using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public int currentScore;
    public TMPro.TextMeshProUGUI scoreText;
    
   
    void Start()
    {
        currentScore = 10;
        scoreText.text = currentScore.ToString()  + " points";
    }

 
    void Update()
    {
        
    }

    public void GainScore(int scoreToGain)
    {
        currentScore += scoreToGain;
        scoreText.text = currentScore.ToString() + " points";
    }
    
    public void LoseScore(int scoreToLose)
    {
        if (currentScore - scoreToLose < 0)
        {
            currentScore = 0;
            scoreText.text = currentScore.ToString() + " points";
        }
        else
        {
            currentScore -= scoreToLose;
            scoreText.text = currentScore.ToString() + " points";
        }
    }


}
