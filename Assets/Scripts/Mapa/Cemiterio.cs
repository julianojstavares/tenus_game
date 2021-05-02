using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cemiterio : MonoBehaviour
{
    private Narrador narrador;
    private Lizaro lizaro;
    private Txt_Cemiterio txt;
    private bool waitOption = false;
    private CidadeElfosInimigos cidadeElfosInimigos;

    private void Awake()
    {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        lizaro = GameObject.FindGameObjectWithTag("Player").GetComponent<Lizaro>();
        txt = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_Cemiterio>();
        cidadeElfosInimigos = GameObject.FindGameObjectWithTag("Map").GetComponent<CidadeElfosInimigos>();
    }

    public void Ir()
    {
        narrador.Diz(txt.chegada);
        lizaro.Escolhas(3);
        waitOption = true;
    }

    private void Continuar()
    {
        narrador.Diz(txt.partida);
        cidadeElfosInimigos.Ir();
    }

    private void Update()
    {
        if (waitOption)
        {
            switch (lizaro.GetOpcao())
            {
                case 1:
                    waitOption = false;
                    lizaro.SetTemArma(true);
                    Continuar();
                    break;
                case 2:
                    waitOption = false;
                    lizaro.SetTemRoupa(true);
                    Continuar();
                    break;
                case 3:
                    waitOption = false;
                    lizaro.SetTemArma(true);
                    lizaro.SetTemRoupa(true);
                    Continuar();
                    break;
                default:
                    break;
            }
        }
    }
}
