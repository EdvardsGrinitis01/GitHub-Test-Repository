using UnityEngine;

public class Line : MonoBehaviour
{
    public Transform a, b;
    Collider MyC;
    RaycastHit hit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyC = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(a.position, b.position);

        if (Physics.Linecast(a.position, b.position))
        {
            if (hit.collider != MyC)
            {
                Debug.Log("Hit");
                GetComponent<Script1>().Speedy();
            }
        }

        else
        {
            
        }
    }
}
