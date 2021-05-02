using UnityEngine;

public class Tenus : MonoBehaviour
{
    private Narrador narrador;
    private Lizaro lizaro;
    private Txt_Tenus txt;
    private bool waitOption = false;
    private Cemiterio cemiterio;
    private BaseAvancada baseAvancada;
    private CidadeElfosInimigos cidadeElfosInimigos;

    private void Awake()
    {
        narrador = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Narrador>();
        lizaro = GameObject.FindGameObjectWithTag("Player").GetComponent<Lizaro>();
        txt = GameObject.FindGameObjectWithTag("DungeonMaster").GetComponent<Txt_Tenus>();
        cemiterio = GameObject.FindGameObjectWithTag("Map").GetComponent<Cemiterio>();
        baseAvancada = GameObject.FindGameObjectWithTag("Map").GetComponent<BaseAvancada>();
        cidadeElfosInimigos = GameObject.FindGameObjectWithTag("Map").GetComponent<CidadeElfosInimigos>();
    }
    public void Jogar()
    {
        narrador.Silencio();
        narrador.Diz(txt.intro);
        narrador.Silencio();
        lizaro.Escolhas(3);
        waitOption = true;
    }

    private void Update()
    {
        if (waitOption)
        {
            switch (lizaro.GetOpcao())
            {
                case 1:
                    waitOption = false;
                    cemiterio.Ir();
                    break;
                case 2:
                    waitOption = false;
                    baseAvancada.Ir();
                    break;
                case 3:
                    waitOption = false;
                    cidadeElfosInimigos.Ir();
                    break;
                default:
                    break;
            }
        }
    }
}
