using UnityEngine;

public class Narrador: MonoBehaviour
{
    private TMPro.TMP_Text output;

    private void Awake() {
        output = GameObject.FindGameObjectWithTag("Output").GetComponent<TMPro.TMP_Text>();
    }

    public void Diz(string msg)
    {
        output.text += msg;
        output.text += "<br>";
    }

    public void NovaHistoria()
    {
        output.text = "";
    }

    public void Silencio()
    {
        output.text += "<br>";
    }
}
