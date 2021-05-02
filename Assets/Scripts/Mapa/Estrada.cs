using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrada : MonoBehaviour
{
    private Narrador narrador;
    private Lizaro lizaro;
    private Txt_Estrada txt;
    private bool waitOption = false;
    private bool waitOptionGruta = false;
    private Gruta gruta;
    private VilaVerdejante vilaVerdejante;

    private void Awake()
    {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        lizaro = GameObject.FindGameObjectWithTag("Player").GetComponent<Lizaro>();
        txt = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_Estrada>();
        gruta = GameObject.FindGameObjectWithTag("Map").GetComponent<Gruta>();
        vilaVerdejante = GameObject.FindGameObjectWithTag("Map").GetComponent<VilaVerdejante>();
    }

    public void Ir()
    {
        narrador.Diz(txt.intro);
        if (lizaro.GetLeitor())
        {
            narrador.Diz(txt.pergunta);
            lizaro.Escolhas(2);
            waitOption = true;
        }
        else
        {
            narrador.Diz(txt.gruta);
            lizaro.Escolhas(2);
            waitOptionGruta = true;
        }
    }

    private void Update()
    {
        if (waitOption)
        {
            if (lizaro.GetOpcao() == 1)
            {
                waitOption = false;
                narrador.Diz(txt.comer);
            }
            else if (lizaro.GetOpcao() == 2)
            {
                waitOption = false;
                narrador.Diz(txt.gruta);
                lizaro.Escolhas(2);
                waitOptionGruta = true;
            }
        }

        if (waitOptionGruta)
        {
            if(lizaro.GetOpcao() == 1)
            {
                waitOptionGruta = false;
                gruta.Ir();
            }
            else if (lizaro.GetOpcao() == 2)
            {
                waitOptionGruta = false;
                vilaVerdejante.Ir();
            }
        }
    }
}