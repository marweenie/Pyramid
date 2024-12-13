using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 100f;
    public float gravity = -21.81f;  // Gravity value
    public float jumpHeight = 2f;   // Jump height

    private CharacterController controller;
    private Vector3 velocity; // Used to store the player's velocity

    void Start()
    {
        // Get the CharacterController component
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Get player input for movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Move the player forward/backward
        Vector3 moveDirection = transform.forward * vertical * moveSpeed * Time.deltaTime;
        controller.Move(moveDirection);

        // Rotate the player left/right
        float rotation = horizontal * turnSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        // Apply gravity manually
        if (controller.isGrounded)
        {
            // Reset vertical velocity when grounded
            velocity.y = -1f; // Slight downward force to ensure the player stays grounded

            // Check for jump input
            if (Input.GetButtonDown("Jump"))
            {
                // Apply jump force
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }
        }
        else
        {
            // Apply gravity when not grounded
            velocity.y += gravity * Time.deltaTime;
        }

        // Apply velocity (gravity + movement)
        controller.Move(velocity * Time.deltaTime);
    }

    public void StartFalling()
    {
        // Enable gravity for the player to fall (if not already falling)
        if (!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }
    }

    // Detect collisions with tiles
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("GoodTile"))
        {
            Debug.Log("Correct tile! Keep going.");
        }
        else if (hit.collider.CompareTag("BadTile"))
        {
            Debug.Log("Wrong tile! Game over.");
            // Wait 1 second before starting to fall
            Invoke("StartFalling", 3f);
        }
    }
}
