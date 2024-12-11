using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitBehavior : MonoBehaviour
{
    public GameManager gameManager; // Drag the GameManager here in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player fell into the pit.");
            gameManager.GameOver();
        }
    }
}
