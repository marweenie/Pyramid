using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // This function will be called when the Start Game button is clicked
    public void StartGame()
    {
        // Load the next scene (assuming your game scene is indexed as 1 in Build Settings)
        SceneManager.LoadScene(1);
    }

    // This function will be called when the Exit button is clicked
    public void ExitGame()
    {
        // Close the application
        Application.Quit();
        // If running in the editor, stop play mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}

