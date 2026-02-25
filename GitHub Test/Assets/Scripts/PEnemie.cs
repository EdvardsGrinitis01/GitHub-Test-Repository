using System.Collections;
using UnityEngine;

public class PEnemie : MonoBehaviour
{
    //Movement Variables
    [SerializeField] private Vector3 movementDir;
    [SerializeField] private float movementSpeed;
    [SerializeField] private bool movingRight;

    //Ground Check
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float groundCheckDist;
    [SerializeField] private bool isGrounded;
    [SerializeField] private Transform groundCheckOrigion;
    [SerializeField] private float forwardOffset = 0.5f;

    Rigidbody rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(movementDir.x * movementSpeed, rb.linearVelocity.y, movementDir.z * movementSpeed);

        isGrounded = Physics.Raycast(groundCheckOrigion.position + (movementDir * forwardOffset), Vector3.down, groundCheckDist, groundMask);

        if (isGrounded)
        {
            movementDir.x *= -1;
        }

    }

   void MoveDirDelay(Vector3 Dir)
    {
        movementDir.x = Dir.x;
    }
}
