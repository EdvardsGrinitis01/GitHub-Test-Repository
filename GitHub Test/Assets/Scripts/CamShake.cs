using Unity.Cinemachine;
using UnityEngine;

public class CamShake : MonoBehaviour
{

    public CinemachineImpulseSource ScreenShake;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            ScreenShake.GenerateImpulse();
        }
    }
}
