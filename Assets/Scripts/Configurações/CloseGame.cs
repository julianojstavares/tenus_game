using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour
{
    public void Now()
    {
        Application.Quit();
        #if UNITY_EDITOR
         UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Now();
        }
    }
}
