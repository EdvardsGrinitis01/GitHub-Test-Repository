using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CubePlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Get input
        float horizontalInput = 0f;
        if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1f;
        }

        // Current vertical velocity (gravity is already applied)
        float verticalVelocity = rb.velocity.y;

        // Apply horizontal velocity, keeping vertical velocity
        Vector3 newVelocity = new Vector3(horizontalInput * moveSpeed, verticalVelocity, 0f);
        rb.velocity = newVelocity;
    }
}