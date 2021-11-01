using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScriptPS : MonoBehaviour
{
    private float timePassed = 160;
    public TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        int sec = (int) (timePassed % 60);
        int min = (int) (timePassed / 60) % 60;

        string timerString = $" {min:0}min {sec:00}s ";
        text.text = timerString;
        
        if (timePassed > 0)
        {
            timePassed -= Time.deltaTime;
        }

        else
        {
            SceneManager.LoadScene("SceneP");
        }
        
    }
    
}
