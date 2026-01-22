using UnityEngine;
using System.Collections;

public class Delayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            StartCoroutine("Murder");
        }
    }

    IEnumerator Murder()
    {
        yield return new WaitForSecondsRealtime(0f);
        Destroy(gameObject);

    }

}
