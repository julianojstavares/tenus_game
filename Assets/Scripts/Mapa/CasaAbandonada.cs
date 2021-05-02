using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaAbandonada : MonoBehaviour
{
    private Narrador narrador;
    private Lizaro lizaro;
    private Txt_CasaAbandonada txt;
    private Estrada estrada;
    private bool waitOption = false;
    private bool waitOptionSair = false;
    private bool waitOptionGruta = false;

    private void Awake()
    {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        lizaro = GameObject.FindGameObjectWithTag("Player").GetComponent<Lizaro>();
        txt = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_CasaAbandonada>();
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
                narrador.Diz(txt.ler);
                lizaro.SetLeitor(true);
                estrada.Ir();
            }
            else if(lizaro.GetOpcao() == 2)
            {
                narrador.Diz(txt.sairCasa);
                lizaro.Escolhas(2);
                if(waitOptionSair)
                {
                    if (lizaro.GetOpcao() == 1)
                    {
                        waitOptionSair = false;
                        narrador.Diz(txt.entrarGruta);
                        lizaro.Escolhas(2);
                        if (waitOptionGruta) 
                        {
                            if (lizaro.GetOpcao() == 1)
                            {
                                narrador.Diz(txt.comOuro);
                                waitOptionGruta = false;
                                waitOption = false;
                            }
                            else
                            {
                                narrador.Diz(txt.semOuro);
                                estrada.Ir();
                                waitOptionGruta = false;
                                waitOption = false;
                            }
                        }
                    }
                    else
                    {
                        estrada.Ir();
                        waitOptionSair = false;
                        waitOption = false;
                    }
                }
                waitOption = false;
            }
        }
    }
}
