using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script1 : MonoBehaviour
{

    Rigidbody rb;
    Vector3 startPosition;
    public float LeftSpeed = 2f;
    public float RightSpeed = 2f;
    public float BackSpeed = 2f;
    public float ForwardSpeed = 2f;
    StatManager statManager;

    public float JumpForce = 5f;
    bool IsGrounded;

    private void Awake()
    {
        startPosition = transform.position;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        statManager = FindAnyObjectByType<StatManager>();
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

    
    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            IsGrounded = true; 
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            statManager.ChangeCoins(1);
            Destroy(other.gameObject);
        }
        if(other.tag == "Checkpoint")
        {
            statManager.TriggerCheckpoint(1);
        }
        if (other.tag == "KillPlayer")
        {
            transform.position = FindAnyObjectByType<Checkpoint>().checkpointPositions[statManager.currentCheckpoint].position;
        }
    }  

    public void Die()
    {
        transform.position = startPosition;
    }
    
}   
