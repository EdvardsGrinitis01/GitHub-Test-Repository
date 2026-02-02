using UnityEngine;

public class Accessor : MonoBehaviour
{
    public TextUI texts;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(","))
        {
            texts.Lives--;
        }
    }
}
