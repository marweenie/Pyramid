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

    private void Start()
    {

        // Store the player's initial position
        initialPlayerPosition = playerTransform.position;
    }

    public void GameOver()
    {
        Debug.Log("Game Over!");
        // Show the Game Over text too but code not done
 
    }

    private void RestartGame()
    {

        // Reset the player's position to the initial spawn
        //playerTransform.position = initialPlayerPosition;

    }
}
