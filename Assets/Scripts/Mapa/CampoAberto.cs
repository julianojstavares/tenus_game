using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampoAberto : MonoBehaviour
{
    private Narrador narrador;
    private Lizaro lizaro;
    private Txt_CampoAberto txt;
    private CasaAbandonada casaAbandonada;
    private Estrada estrada;
    private bool waitOption = false;

    private void Awake()
    {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        lizaro = GameObject.FindGameObjectWithTag("Player").GetComponent<Lizaro>();
        txt = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_CampoAberto>();
        casaAbandonada = GameObject.FindGameObjectWithTag("Map").GetComponent<CasaAbandonada>();
        estrada = GameObject.FindGameObjectWithTag("Map").GetComponent<Estrada>();
    }

    public void Ir()
    {
        narrador.Diz(txt.intro);
        lizaro.Escolhas(2);
        waitOption = true;
    }

    private void Update()
    {
        if (waitOption)
        {
            if (lizaro.GetOpcao() == 1)
            {
                waitOption = false;
                casaAbandonada.Ir();
            }
            else if (lizaro.GetOpcao() == 2)
            {
                waitOption = false;
                estrada.Ir();
            }
        }
    }

}
