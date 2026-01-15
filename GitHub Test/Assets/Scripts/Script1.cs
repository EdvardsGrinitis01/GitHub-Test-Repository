using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] public float LeftSpeed = 2f;
    [SerializeField] public float RightSpeed = 2f;
    [SerializeField] public float BackSpeed = 2f;
    [SerializeField] public float ForwardSpeed = 2f;

    [SerializeField] public float JumpForce = 5f;
    [SerializeField] bool IsGrounded;
    [SerializeField] float groundCheckDistance;
    [SerializeField] Transform GroundCheckOrigin;
    [SerializeField] LayerMask groundLayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            Debug.Log("Right");
            rb.AddForce(Vector3.right * RightSpeed, ForceMode.Impulse);
        }
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("Left");
            rb.AddForce(Vector3.left * LeftSpeed, ForceMode.Impulse);
        }
        if (Input.GetKeyDown("s"))
        {
            Debug.Log("Back");
            rb.AddForce(Vector3.back * LeftSpeed, ForceMode.Impulse);
        }
        if (Input.GetKeyDown("w"))
        {
            Debug.Log("Forward");
            rb.AddForce(Vector3.forward * LeftSpeed, ForceMode.Impulse);
        }


        if (Input.GetKeyDown("space") && IsGrounded)
        {
            Debug.Log("Up");
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            IsGrounded = false;
            {
                IsGrounded = Physics.Raycast(GroundCheckOrigin.position, Vector3.down, groundCheckDistance, groundLayer);
            }
        }
    }
}
