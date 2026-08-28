using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI")]
    public GameObject playPanel;
    public GameObject gameOverPanel;

    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    private int score;
    private int highScore;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Time.timeScale = 0;

        score = 0;

        highScore = PlayerPrefs.GetInt("HighScore", 0);

        scoreText.text = "Score : 0";
        highScoreText.text = "Highest Score : " + highScore;

        playPanel.SetActive(true);
        gameOverPanel.SetActive(false);

        scoreText.gameObject.SetActive(false);
    }

    public void PlayGame()
    {
        playPanel.SetActive(false);

        scoreText.gameObject.SetActive(true);

        Time.timeScale = 1;
    }

    public void AddScore(int amount)
    {
        score += amount;

        scoreText.text = "Score : " + score;
    }

    public void GameOver()
    {
        Time.timeScale = 0;

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }

        highScoreText.text = "Highest Score : " + highScore;

        gameOverPanel.SetActive(true);
    }
}