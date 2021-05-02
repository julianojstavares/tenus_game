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
        lizaro.EscolhaDupla();
        if (lizaro.GetOpcao() == 1)
        {
            Combate();
        }
        else
        {
            if (lizaro.RolarDado(6) > 5 || lizaro.GetTemRoupa() == true)
            {
                narrador.Diz(txt.furtivo);
                campoAberto.Ir();
            }
            else
            {
                Combate();
            }
        }
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
                    if (lizaro.GetOpcao() == 1)
                    {
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
                    else
                    {
                        ninhoAranha.Ir();
                    }
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
}
