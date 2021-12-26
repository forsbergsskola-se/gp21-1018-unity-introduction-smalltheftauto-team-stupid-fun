using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Nicely prepared. Too bad that it did not come to use.
public class ScoreSystem : MonoBehaviour
{
    public int currentScore;
    public TMPro.TextMeshProUGUI scoreText;
    
   
    void Start()
    {
        currentScore = 10;
        scoreText.text = "Score: " + currentScore.ToString();
    }

 
    void Update()
    {
        
    }

    public void GainScore(int scoreToGain)
    {
        currentScore += scoreToGain;
        scoreText.text = "Score: " + currentScore.ToString();
    }
    
    public void LoseScore(int scoreToLose)
    {
        if (currentScore - scoreToLose < 0)
        {
            currentScore = 0;
            scoreText.text = "Score: " + currentScore.ToString();
        }
        else
        {
            currentScore -= scoreToLose;
            scoreText.text = "Score: " + currentScore.ToString();
        }
    }


}
