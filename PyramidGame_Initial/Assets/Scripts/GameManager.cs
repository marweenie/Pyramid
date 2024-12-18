using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // For restarting the scene
using UnityEngine.UI; // For displaying Game Over text
using TMPro; // For TextMeshPro


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverTMPText; // Reference to the TMP text component

    public Transform playerTransform; // Reference to the player
    public Vector3 initialPlayerPosition; // Starting position for the player

    public GameObject WinText; // Reference to the Win text object
    public GameObject gameOverText; // Reference to the Game Over text object
    public GameObject quitGameButton; // Reference to the Quit Game button object
    public GameObject playGameAgainButton; // Reference to the Play Game Again button object
    public GameObject WinnerquitGameButton; // Reference to the Quit Game button object
    public GameObject WinnerplayGameAgainButton; // Reference to the Play Game Again button object

    private void Start()
    {

        // Store the player's initial position
        initialPlayerPosition = playerTransform.position;

        gameOverText.SetActive(false); // Ensure Game Over text is initially hidden
        quitGameButton.SetActive(false); // Ensure Quit Game button is initially hidden
        playGameAgainButton.SetActive(false); // Ensure Play Game Again button is initially hidden

        WinText.SetActive(false); // Ensure Win text is initially hidden
        WinnerquitGameButton.SetActive(false); // Ensure Win Quit Game button is initially hidden
        WinnerplayGameAgainButton.SetActive(false); // Ensure Win Play Game Again button is initially hidden
    }

    public void GameOver()
    {
        Debug.Log("Game Over!");

        gameOverText.SetActive(true); // Show Game Over text
        quitGameButton.SetActive(true); // Show Quit Game button
        playGameAgainButton.SetActive(true); // Show Play Game Again button

    }

    public void Winner()
    {
        Debug.Log("You Win!");

        WinText.SetActive(true); // Show Win text
        WinnerquitGameButton.SetActive(true); // Show Quit Game button
        WinnerplayGameAgainButton.SetActive(true); // Show Play Game Again button
    }
    private void RestartGame()
    {

        // Reset the player's position to the initial spawn
        //playerTransform.position = initialPlayerPosition;

    }
}
