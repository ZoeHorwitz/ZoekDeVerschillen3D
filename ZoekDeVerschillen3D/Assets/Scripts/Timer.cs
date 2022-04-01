using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public Slider timerSlider;
    public Text timerText;
    public float gameTime;

    private bool stopTimer;
    void Start()
    {
        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        float time = gameTime - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{0:0};{0:0}", minutes, seconds);

        if ( time <= 0)
        {
            stopTimer = true;
            SceneManager.LoadScene("GameOver");

        }
        if ( stopTimer == false)
        {
            timerText.text = textTime;
            timerSlider.value = time;
        }

        
    }
}
