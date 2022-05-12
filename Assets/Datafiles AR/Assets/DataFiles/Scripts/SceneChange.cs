using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public void forestScene()
    {
        SceneManager.LoadScene(2);

    }
    public void TempleScene()
    {
        SceneManager.LoadScene(3);

    }
    public void BackScene()
    {
        SceneManager.LoadScene(1);

    }
}
