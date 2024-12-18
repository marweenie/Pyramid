using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import the UI namespace
using UnityEngine.SceneManagement; // Import SceneManagement namespace
using TMPro; // For TextMeshPro

public class WinTrigger : MonoBehaviour
{
    //public GameObject winText; // Reference to the Text component
    //public Button quitButton; // Reference to the Quit Button
    //public Button playAgainButton; // Reference to the Play Again Button

    public GameManager gameManager; // Drag the GameManager here in the Inspector

    //private void Start()
    //{
    //    winText.SetActive(false); // Ensure the text is initially inactive
    //    quitButton.gameObject.SetActive(false); // Ensure the button is initially inactive
    //    playAgainButton.gameObject.SetActive(false); // Ensure the button is initially inactive

    //    quitButton.onClick.AddListener(QuitGame); // Add listener to Quit button
    //    playAgainButton.onClick.AddListener(PlayAgain); // Add listener to Play Again button
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowWinScreen(); // Call the function to show the win screen
        }
    }

    private void ShowWinScreen()
    {
        //winText.SetActive(true); // Activate the win screen text
        //quitButton.gameObject.SetActive(true); // Activate the Quit button
        //playAgainButton.gameObject.SetActive(true); // Activate the Play Again button

        gameManager.Winner();
    }

    //private void QuitGame()
    //{
    //    Application.Quit(); // Quit the application
    //    #if UNITY_EDITOR
    //    UnityEditor.EditorApplication.isPlaying = false; // For use in the editor
    //    #endif
    //}

    //private void PlayAgain()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
    //}
}

