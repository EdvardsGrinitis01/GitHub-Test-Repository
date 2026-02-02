using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextUI : MonoBehaviour
{
    public TextMeshProUGUI LivesText;
    public float Lives = 10f;
    public Button button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button.onClick.AddListener(UseThis);
    }

    // Update is called once per frame
    void Update()
    {
        LivesText.text = Lives.ToString();
        if(Input.GetKeyDown(","))
        {
            Lives++;
        }
        if (Input.GetKeyDown("."))
        {
            Lives--;
        }
    }

    void UseThis()
    {
        Debug.Log("Button Clicked");
    }
}
