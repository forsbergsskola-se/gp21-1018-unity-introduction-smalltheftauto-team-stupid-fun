using TMPro;
using UnityEngine;

public class TimerEK : MonoBehaviour {

    float timePassed = 10;
    public TextMeshProUGUI text;

    private void Update() {
        if (timePassed > 0) {
            timePassed -= Time.deltaTime;
        }
    }
}
