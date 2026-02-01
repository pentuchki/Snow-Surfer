using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    int score = 0;

    public void AddScore(int additionalScore)
    {
        score = score + additionalScore; // score += additionalScore;
        scoreText.text = "Score: " + score;
    }
}
