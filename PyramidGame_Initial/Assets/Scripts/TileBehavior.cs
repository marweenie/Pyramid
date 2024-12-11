using UnityEngine;
using System.Collections;

public class TileBehavior : MonoBehaviour
{
    public bool isBadTile = false; // true for bad tiles only!
    private Rigidbody tileRigidbody;
    public GameManager gameManager;  // Reference to the GameManager script
    public PlayerMovement playerMovement; // Reference to the PlayerMovement script
    public float delayBeforeFall = 0.5f; // Time before player starts falling

    private void Start()
    {
        tileRigidbody = gameObject.AddComponent<Rigidbody>();
        tileRigidbody.isKinematic = true; // Initially, the tile should not move
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameManager == null)
        {
            Debug.LogError("GameManager is not assigned!");
        }
        else
        {
            gameManager.GameOver();
        }

        if (other.CompareTag("Player") && isBadTile)
        {
            // Trigger the game over when the player steps on a bad tile
            gameManager.GameOver();

            // Start the falling process for the tile and player
            StartCoroutine(FallWithPlayer());
        }
    }

    private IEnumerator FallWithPlayer()
    {
        // Wait briefly before making the tile fall
        yield return new WaitForSeconds(0.3f);

        // Allow tile to fall by disabling isKinematic
        tileRigidbody.isKinematic = false;

        // Wait for a brief moment before the player falls
        yield return new WaitForSeconds(delayBeforeFall);

        // Trigger the player's fall (you can call a function in PlayerMovement or set the gravity)
        if (playerMovement != null)
        {
            // Set a flag in PlayerMovement to allow falling (or trigger gravity)
            playerMovement.StartFalling();
        }

        // Destroy the tile after it has fallen for 2 seconds
        Destroy(gameObject, 2f);
    }
}
