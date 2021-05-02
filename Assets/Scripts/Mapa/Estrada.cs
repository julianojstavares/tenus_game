using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrada : MonoBehaviour
{
    private Narrador narrador;
    private Lizaro lizaro;
    private Txt_Estrada txt;

    private void Awake()
    {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        lizaro = GameObject.FindGameObjectWithTag("Player").GetComponent<Lizaro>();
        txt = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_Estrada>();
    }

    public void Ir()
    {
        narrador.Diz(txt.intro);
        if (lizaro.GetLeitor())
        {
            narrador.Diz(txt.pergunta);
            lizaro.Escolhas(2);
            if (lizaro.GetOpcao() == 1)
            {
                narrador.Diz(txt.comer);
            }
            else
            {
                GameOver();
            }
        }
        else
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        narrador.Diz(txt.fim);
    }
}