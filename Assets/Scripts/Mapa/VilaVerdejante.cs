using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VilaVerdejante : MonoBehaviour
{
    private Narrador narrador;
    private Txt_VilaVerdejante txt;

    private void Awake()
    {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        txt = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_VilaVerdejante>();
    }

    public void Ir()
    {
        narrador.Diz(txt.fim);
        NewGame.waitInput = true;
    }
}
