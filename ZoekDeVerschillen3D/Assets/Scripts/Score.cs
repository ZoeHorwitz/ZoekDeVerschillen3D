using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    public int wrong;
    public TextMeshProUGUI scoreTextWrong;
    public TextMeshProUGUI scoreTextRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTextWrong.text = " " + wrong;
        if (wrong > 2)
        {
            SceneManager.LoadScene("GameOver");
        }
        scoreTextRight.text = " " + score;
    }
}
