using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinhoAranha : MonoBehaviour
{
    private Narrador narrador;
    private Lizaro lizaro;
    private CasaAbandonada casaAbandonada;
    private Txt_NinhoAranha txt;

    private void Awake()
    {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        lizaro = GameObject.FindGameObjectWithTag("Player").GetComponent<Lizaro>();
        casaAbandonada = GameObject.FindGameObjectWithTag("Map").GetComponent<CasaAbandonada>();
        txt = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_NinhoAranha>();
    }

    public void Ir()
    {
        narrador.Diz(txt.txtAranhaChegando);
        if (lizaro.RolarDado(20) > 10)
        {
            narrador.Diz(txt.txtFugindo);
            casaAbandonada.Ir();
        }
        else
        {
            narrador.Diz(txt.txtMorte);
            NewGame.waitInput = true;
        }

    }
}
