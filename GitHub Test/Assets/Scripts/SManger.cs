using UnityEngine;
using UnityEngine.SceneManagement;

public class SManger : MonoBehaviour
{
    public string SceneName;
    public void scene_changer(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    public void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(SceneName);
            }

                

        }
    }
}
