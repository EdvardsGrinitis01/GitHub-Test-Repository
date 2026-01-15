using UnityEngine;
using UnityEngine.SceneManagement;

public class SManger : MonoBehaviour
{
    public void scene_changer(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
