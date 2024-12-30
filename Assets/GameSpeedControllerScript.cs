using UnityEngine;

public class GameSpeedControllerScript : MonoBehaviour
{
    public int nextThreshold =30;
    public LogicScript l;
    public int scoreIncrement = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int currentScore = LogicScript.playerScore;

        // Check if the score has passed the next threshold for speed increase
        if (currentScore >= nextThreshold)
        {
            IncreaseSpeed();
            nextThreshold += scoreIncrement; // Update to the next threshold
        }
    }

    void IncreaseSpeed()
    {
        Time.timeScale += 0.1f; // Increases the overall game speed.
        Debug.Log("Global game speed increased to: " + Time.timeScale);
    }
}
