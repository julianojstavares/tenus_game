using UnityEngine;
using UnityEngine.SceneManagement;
public class OpenScene : MonoBehaviour
{
    public void Name(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
