using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 100f;

    private CharacterController controller;

    void Start()
    {
        // Get the CharacterController component
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Get player input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Move forward/backward
        Vector3 moveDirection = transform.forward * vertical * moveSpeed * Time.deltaTime;
        controller.Move(moveDirection);

        // Rotate left/right
        float rotation = horizontal * turnSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }
}
