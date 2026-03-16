using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Portal : MonoBehaviour
{
    public string Level2;
    public void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(Level2);
    }
}
