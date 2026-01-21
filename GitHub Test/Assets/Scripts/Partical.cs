using Unity.Cinemachine;
using UnityEngine;

public class Partical : MonoBehaviour
{
    public ParticleSystem Laugh;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("l"))
        {
            Laugh.Play();
        }
        
    }
}
