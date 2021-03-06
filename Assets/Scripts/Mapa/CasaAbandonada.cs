using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaAbandonada : MonoBehaviour
{
    private Narrador narrador;
    private Lizaro lizaro;
    private Txt_CasaAbandonada txt;
    private Estrada estrada;
    private Gruta gruta;
    public bool waitOption = false;

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
                waitOption = false;
                narrador.Diz(txt.sair);
                estrada.Ir();
            }
        }
    }
}
