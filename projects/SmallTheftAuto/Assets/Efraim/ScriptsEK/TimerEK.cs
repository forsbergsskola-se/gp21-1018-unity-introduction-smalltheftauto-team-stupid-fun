using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerEK : MonoBehaviour {

    private float timePassed = 10;
    public TextMeshProUGUI text;

    private void Update() {

        int sec = (int) (timePassed % 60);
        int min = (int) (timePassed / 60) % 60;

        string timerString = $" {min:0}min {sec:00}s ";
        text.text = timerString;

        if (timePassed > 0) {
            timePassed -= Time.deltaTime;
        } else {
            SceneManager.LoadScene("SceneEK");
        }
    }
}
