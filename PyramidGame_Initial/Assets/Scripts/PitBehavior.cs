using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PitBehavior : MonoBehaviour
{
    public GameManager gameManager; // Drag the GameManager here in the Inspector

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("DeathFloor"))
    //    {
    //        UnityEngine.Debug.Log("Player fell into the pit.");
    //        gameManager.GameOver();
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UnityEngine.Debug.Log("Player fell into the pit.");
            gameManager.GameOver();
        }
    }

    //private Rigidbody rb;

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}

    //void OnCollisionEnter(Collision collision)
    //{
    //    // Check if the player lands on an object tagged as "DeathFloor"
    //    if (collision.gameObject.CompareTag("DeathFloor"))
    //    {
    //        UnityEngine.Debug.Log("Player has landed on the ground.");
    //        // Add any additional code you want to execute when the player lands

    //        gameManager.GameOver();

    //        //// Ensure that the collision comes from above by checking the player's y velocity
    //        //if (rb.velocity.y <= 0)
    //        //{
    //        //    UnityEngine.Debug.Log("Player has landed on the ground.");
    //        //    // Add any additional code you want to execute when the player lands

    //        //    gameManager.GameOver();
    //        //}
    //    }
    //}
}
