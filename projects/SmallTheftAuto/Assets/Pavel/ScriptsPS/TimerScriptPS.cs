using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScriptPS : MonoBehaviour
{
    private float timePassed = 0;
    public Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        Debug.Log(timePassed);

        double rounder = System.Math.Round(timePassed, 2);
        text.text = rounder.ToString();
    }
    
}
