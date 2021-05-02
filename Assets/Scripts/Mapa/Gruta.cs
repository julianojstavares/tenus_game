using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gruta : MonoBehaviour
{
    private Narrador narrador;
    private Lizaro lizaro;
    private Txt_Gruta txt;
    private VilaVerdejante vilaVerdejante;
    public bool waitOption = false;

    private void Awake()
    {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        lizaro = GameObject.FindGameObjectWithTag("Player").GetComponent<Lizaro>();
        txt = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_Gruta>();
        vilaVerdejante = GameObject.FindGameObjectWithTag("Map").GetComponent<VilaVerdejante>();
    }

    public void Ir()
    {
        narrador.Diz(txt.entrarGruta);
        lizaro.Escolhas(2);
        waitOption = true;
    }

    private void Update()
    {
        if (waitOption)
        {
            if (lizaro.GetOpcao() == 1)
            {
                narrador.Diz(txt.comOuro);
                waitOption = false;
            }
            else if (lizaro.GetOpcao() == 2)
            {
                narrador.Diz(txt.semOuro);
                vilaVerdejante.Ir();
                waitOption = false;
            }
        }
    }
}
