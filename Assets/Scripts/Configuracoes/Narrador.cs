using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Narrador: MonoBehaviour
{
    public TMPro.TMP_Text output;
    public void Diz(string msg)
    {
        output.text += msg;
        output.text += "<br>";
    }
}
