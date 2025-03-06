using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int PlayerScore;
    public Text ScoreText;
    public GameObject GameOverScreen;
    public void AddScore(int scoreToAdd)
    {
        PlayerScore += scoreToAdd;
        ScoreText.text = PlayerScore.ToString();
    }

    public void RestartGame()
    {
        PlayerScore = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
