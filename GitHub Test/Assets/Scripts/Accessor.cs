using UnityEngine;

public class Accessor : MonoBehaviour
{
    public TextUI texts;

    void Update()
    {
        if(Input.GetKeyDown(","))
        {
            texts.Lives--;
        }
    }
}
