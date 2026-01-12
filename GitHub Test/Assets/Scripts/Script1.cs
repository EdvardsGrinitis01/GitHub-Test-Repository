using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    Rigidbody rb;
    public float JumpForce = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("AAAA");
            rb.AddForce(-1, 0, 0);
        }
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Apples");
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }
}
