using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text scoreText;
    public TMP_Text endScore;
    public TMP_Text HSText;

    public static int score = 0;
    public static int highscore = 0;

    private void Start()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }

    private void Awake()
    {
        instance = this; 
    }

    private void Update()
    {
        if (score > highscore) 
        { 
            highscore = score;
        }
        endScore.text = "You scored " + score.ToString() + " points";
        HSText.text = "High score: " + highscore.ToString() + " points";

    }

    public void AddToScore(int invaderScore) 
    {
        score += invaderScore;
        scoreText.text = "SCORE: " + score.ToString();
    }

    public void ResetScore() 
    { 
        score = 0;
    }
}
