using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text scoreText;

    int score = 0;

    private void Start()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }

    private void Awake()
    {
        instance = this; 
    }

    public void AddToScore(int invaderScore) 
    {
        score += invaderScore;
        scoreText.text = "SCORE: " + score.ToString();
    }
}
