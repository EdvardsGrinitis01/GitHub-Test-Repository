using UnityEngine;
using UnityEngine.SceneManagement;

public class Script1 : MonoBehaviour
{
    Vector3 startPosition;
    StatManager statManager;
    public TextUI texts;

    public float moveSpeed = 10f;
    public float jumpForce = 7f;

    private Rigidbody rb;
    private float moveInput;
    private bool IsGrounded;


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
        moveInput = Input.GetAxis("Horizontal");

        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1.1f))
        {
            if (hit.collider.CompareTag("Ground"))
            {
                IsGrounded = true;
            }
            else
            {
                IsGrounded = false;
            }

            // IDK why this doesnt work with this
        }
        else
        {
            IsGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(moveInput * moveSpeed, rb.linearVelocity.y, 0f);
    }

    public void scene_changer(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
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
        if (other.tag == "Checkpoint")
        {
            statManager.TriggerCheckpoint(other.transform.GetSiblingIndex());
        }
        if (other.tag == "KillPlayer")
        {
            transform.position = FindAnyObjectByType<Checkpoint>().checkpointPositions[statManager.currentCheckpoint].position;

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
