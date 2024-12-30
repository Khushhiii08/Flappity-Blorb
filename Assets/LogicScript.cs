using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public static int playerScore;
    public Text scoreText;
    public int scoreToAdd;
    public GameObject gameOverScreen;

    // [ContextMenu("Increase Score")] to do it from unity itself
    public void addScore()
    {
        playerScore+=scoreToAdd;
        scoreText.text=playerScore.ToString();

    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
