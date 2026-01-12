using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    Rigidbody rb;
    public float LeftSpeed = 2f;
    public float RightSpeed = 2f;
    public float BackSpeed = 2f;
    public float ForwardSpeed = 2f;

    public float JumpForce = 5f;
    bool IsGrounded;

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
        }
    }

    void OnCollisionStay(Collision other) 
    {
        IsGrounded = true;
    }
}
