using UnityEngine;
using TMPro;

public class ScriptObject : MonoBehaviour
{

    public TestObject Invent;
    public TestObject[] AvailbleInvent;
    public int currentIndex = 0;
    public TextMeshProUGUI ID;
    GameObject spawnedObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Apply();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("b"))
        {
            currentIndex++;
            if(currentIndex >= AvailbleInvent.Length)
            {
                currentIndex = 0;
            }
            Invent = AvailbleInvent[currentIndex];
            Apply();
        }
    }

    void Apply()
    {
        if (Invent == null) return;
        ID.text = Invent.Display;

        if(spawnedObject != null)
        {
            Destroy(spawnedObject);
        }

        if(Invent.prefab != null)
        {
            spawnedObject = Instantiate(Invent.prefab, transform.position, transform.rotation);
        }
    }
}
