using System;
using TMPro;
using UnityEngine;

public class TimerEK : MonoBehaviour {

    float timePassed = 10;
    public TextMeshProUGUI text;

    void Update() {

        double rounder = Math.Round(timePassed, 2);
        text.text = rounder.ToString("0.00s");

        if (timePassed > 0) {
            timePassed -= Time.deltaTime;
        }
    }
}
