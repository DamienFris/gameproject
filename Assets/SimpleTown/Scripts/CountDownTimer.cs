using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    [SerializeField] float startTime = 5f;
    [SerializeField] Slider slider;
    [SerializeField] TextMeshProUGUI timerText;

    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        timer = startTime;

        do
        {
            timer -= Time.deltaTime;

            slider.value = timer / startTime;

            FormatText();

            yield return null;
        } while (timer > 0);

        void FormatText()
        {
            int days = (int)(timer / 86400) % 365;
            int hours = (int)(timer / 86400) % 24;
            int minutes = (int)(timer / 86400) % 60;
            int seconds = (int)(timer / 86400);

            timerText.text = "";
            if (days > 0) { timerText.text += days + "d "; }
            if (hours > 0) { timerText.text += hours + "h "; }
            if (minutes > 0) { timerText.text += minutes + "m "; }
            if (seconds > 0) { timerText.text += seconds + "s "; }

        }
    }
    
}

