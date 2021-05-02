using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAvancada : MonoBehaviour
{
    private Narrador narrador;
    private Lizaro lizaro;
    private Txt_BaseAvancada txt;
    private CidadeElfosInimigos cidadeElfosInimigos;
    private bool waitOption = false;

    private void Awake()
    {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        lizaro = GameObject.FindGameObjectWithTag("Player").GetComponent<Lizaro>();
        txt = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_BaseAvancada>();
        cidadeElfosInimigos = GameObject.FindGameObjectWithTag("Map").GetComponent<CidadeElfosInimigos>();
    }

    public void Ir()
    {
        narrador.Diz(txt.intro);
        lizaro.Escolhas(2);
        
    }

    private void Update()
    {
        if (waitOption)
        {
            switch (lizaro.GetOpcao())
            {
                case 1:
                    waitOption = false;
                    if (lizaro.RolarDado(20) > 15)
                    {
                        narrador.Diz(txt.matador);
                        cidadeElfosInimigos.Ir();
                    }
                    else
                    {
                        narrador.Diz(txt.perdedor);
                    }
                    break;
                case 2:
                    waitOption = false;
                    narrador.Diz(txt.furtivo);
                    cidadeElfosInimigos.Ir();
                    break;
                default:
                    break;
            }
        }
    }
}
