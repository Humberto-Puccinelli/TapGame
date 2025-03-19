using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    public static GameController instance;
    void Start()
    {
        instance = this;
    }

    void Update()
    {
        
    }

    public void updateScoreText(int totalScore)
    {
        scoreText.text = totalScore.ToString();
    }
}
