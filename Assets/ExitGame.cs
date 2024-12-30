using UnityEngine;

public class ExitGame : MonoBehaviour
{
    private void Update()
    {
        // Check if the 'Escape' key is pressed.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exit();
        }
    }

    // Exit the game
    private void Exit()
    {
        // If running in the Unity Editor, stop play mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // If running in a built game, quit the application
        Application.Quit();
#endif
    }
}
