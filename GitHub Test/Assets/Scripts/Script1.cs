using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    Rigidbody rb;
    public float JumpForce = 5f;
    public float LeftSpeed = 0.1f;
    public float RightSpeed = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetDownDown("d"))
        {
            Degub.Log("Right");
        }
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("Left");
            rb.AddForce(Vector3.left * LeftSpeed, ForceMode.Impulse);
        }
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Up");
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }
}
