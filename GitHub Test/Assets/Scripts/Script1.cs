using JetBrains.Annotations;
using TMPro;
using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class Script1 : MonoBehaviour
{

    Rigidbody rb;
    Vector3 startPosition;
    StatManager statManager;
    public float LeftSpeed = 2f;
    public float RightSpeed = 2f;
    public float BackSpeed = 2f;
    public float ForwardSpeed = 2f;
    public TextUI texts;

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

        if (texts.Lives == 0)
        {
            Destroy(gameObject);
        }
    }

    public void scene_changer(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
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
            texts.Lives--;
        }

    }  

    public void Speedy()
    {
        transform.position = Vector3.up * 100;
    }

    public void Die()
    {
        transform.position = startPosition;
        texts.Lives--;
    }
    
}   
