using UnityEngine;

public class Spike : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Script1>())
        {
            collision.collider.GetComponent<Script1>().Die();
        }
    }
}
