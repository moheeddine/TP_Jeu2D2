using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    float score = 0f;

    void Update()
    {
        score += Time.deltaTime;
        scoreText.text = "Score : " + (int)score;
        if (scoreText == null) return;

    }
}
