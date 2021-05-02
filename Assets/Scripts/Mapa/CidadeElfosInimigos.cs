using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CidadeElfosInimigos : MonoBehaviour
{
    private Narrador narrador;
    private Lizaro lizaro;
    private Txt_CidadeElfosInimigos txt;
    private CampoAberto campoAberto;
    private CasaAbandonada casaAbandonada;
    private NinhoAranha ninhoAranha;
    private bool waitOption = false;
    private bool waitOptionChave = false;

    private void Awake()
    {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        lizaro = GameObject.FindGameObjectWithTag("Player").GetComponent<Lizaro>();
        txt = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_CidadeElfosInimigos>();
        campoAberto = GameObject.FindGameObjectWithTag("Map").GetComponent<CampoAberto>();
        casaAbandonada = GameObject.FindGameObjectWithTag("Map").GetComponent<CasaAbandonada>();
        ninhoAranha = GameObject.FindGameObjectWithTag("Map").GetComponent<NinhoAranha>();
    }
    public void Ir()
    {
        narrador.Diz(txt.intro);
        lizaro.Escolhas(2);
        waitOption = true;
    }

    private void Combate()
    {
        if (lizaro.GetTemArma())
        {
            narrador.Diz(txt.combateEspada);
            Vitoria();
        }
        else
        {
            switch (lizaro.RolarDado(20))
            {
                case 1:
                    narrador.Diz(txt.derrotado);
                    break;
                case 20:
                    Vitoria();
                    break;
                case 4:
                case 5:
                case 6:
                    narrador.Diz(txt.ferido);
                    lizaro.Escolhas(2);
                    waitOptionChave = true;
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                    Vitoria();
                    break;
                default:
                    Debug.LogWarning("Out of range");
                    break;
            }
        }
    }

    private void Vitoria()
    {
        narrador.Diz(txt.vitoria);
        campoAberto.Ir();
    }

    private void Update()
    {
        if (waitOption)
        {
            if (lizaro.GetOpcao() == 1)
            {
                waitOption = false;
                Combate();
            }
            else if(lizaro.GetOpcao() == 2)
            {
                waitOption = false;
                if (lizaro.RolarDado(6) > 5 || lizaro.GetTemRoupa() == true)
                {
                    narrador.Diz(txt.furtivo);
                    if (lizaro.GetTemRoupa()) { narrador.Diz(txt.disfarce); }
                    campoAberto.Ir();
                }
                else
                {
                    narrador.Diz(txt.naoFurtivo);
                    Combate();
                }
            }
        }

        if (waitOptionChave)
        {
            if (lizaro.GetOpcao() == 1)
            {
                waitOptionChave = false;
                if (lizaro.RolarDado(20) > 15)
                {
                    narrador.Diz(txt.pegouChave);
                    casaAbandonada.Ir();
                }
                else
                {
                    narrador.Diz(txt.semChave);
                    ninhoAranha.Ir();
                }
            }
            else if(lizaro.GetOpcao() == 2)
            {
                waitOptionChave = false;
                ninhoAranha.Ir();
            }
        }
    }
}
