using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    

    public Text scoreText;
    public Text highscoreText;

    
    

    

    // Start is called before the first frame update
    void Start()
    {

        scoreText.text = Snake.score.ToString() + " POINTS";
        highscoreText.text = PlayerPrefs.GetInt("HIGHSCORE",0).ToString();
    }

    private void Update()
    {
        scoreText.text = Snake.score.ToString() + " POINTS";
        if (Snake.score > PlayerPrefs.GetInt("HIGHSCORE",0))
        {
            PlayerPrefs.SetInt("HIGHSCORE", Snake.score);
        }
        
        
    }

}
