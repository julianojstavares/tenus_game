using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public static bool waitInput = false;
    public TMPro.TMP_Text message;
    public void Load()
    {
        SceneManager.LoadScene("Menu");
    }

    private void Update()
    {
        if (waitInput)
        {
            message.enabled = true;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Load();
                message.enabled = false;
                waitInput = false;
            }
        }
    }
}
