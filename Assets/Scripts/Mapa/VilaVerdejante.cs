using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VilaVerdejante : MonoBehaviour
{
    private Narrador narrador;
    private Lizaro lizaro;
    private Txt_VilaVerdejante txt;
    private VilaVerdejante vilaVerdejante;

    private void Awake()
    {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        lizaro = GameObject.FindGameObjectWithTag("Player").GetComponent<Lizaro>();
        txt = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_VilaVerdejante>();
        vilaVerdejante = GameObject.FindGameObjectWithTag("Map").GetComponent<VilaVerdejante>();
    }

    public void Ir()
    {
        narrador.Diz(txt.fim);
    }
}
